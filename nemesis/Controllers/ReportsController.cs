using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using nemesis.Migrations;
using nemesis.Models;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;
using nemesis.Models.Repositories;
using nemesis.ViewModels;
using System;
using System.Composition;
using System.Diagnostics;


namespace nemesis.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IReportRepository _reportRepository;
        private readonly IInvestigationRepository _investigationRepository;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger<ReportsController> _logger;

        public ReportsController(
            IReportRepository reportRepository,
            UserManager<IdentityUser> userManager,
            IInvestigationRepository investigationRepository,
            IEmailSender emailSender,
            ILogger<ReportsController> logger)
        {
            _reportRepository = reportRepository;
            _investigationRepository = investigationRepository;
            _userManager = userManager;
            _emailSender = emailSender;
            _logger = logger;
        }



        public IActionResult Index(int currentPage = 1, FilterViewModel filter = null)
        {


            try
            {
                int reportsPerPage = 10;
                var reports = _reportRepository.getAllReports(filter);

                // Pagination
                int totalReports = reports.Count();
                int totalPages = (int)Math.Ceiling((double)totalReports / reportsPerPage);

                currentPage = Math.Max(1, Math.Min(currentPage, totalPages));

                int startIndex = (currentPage - 1) * reportsPerPage;
                var pagedReports = reports.Skip(startIndex).Take(reportsPerPage);

                var model = new ReportsListViewModel()
                {
                    TotalReports = totalReports,
                    Reports = pagedReports,
                    ReportsPerPage = reportsPerPage,
                    CurrentPage = currentPage,
                    FilterSelectionAllLocations = _reportRepository.getAllLocations(),
                    FilterSelectionAllReporters = _reportRepository.getAllReporterNames(),
                    FilterSelectionAllCategories = _reportRepository.getAllCategories().Select(c => c.Name),
                    FilterSelectionAllStatus = _reportRepository.getAllStatuses().Select(c => c.Name),
                    Filter = filter ?? new FilterViewModel()
                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }
            
        


        public IActionResult Details(int id)
        {
            try
            {
                var report = _reportRepository.GetReportById(id);
                var model = new ReportViewModel()
                {
                    Id = report.Id,
                    Title = report.Title,
                    Description = report.Description,
                    Location = report.Location,
                    DateSpotted = report.DateSpotted,
                    DateOfReport = report.DateOfReport,
                    ImageUrl = report.ImageUrl,
                    Category = new CategoryViewModel()
                    {
                        Id = report.Category.Id,
                        Name = report.Category.Name
                    },
                    CreatedByUser = report.CreatedByUser,
                    InvestigationId = report.InvestigationId,
                    Upvotes = report.Upvotes
                };

                if (report.ImageUrl.IsNullOrEmpty())
                {
                    model.ImageUrl = "/images/DefaultImage.png";
                }

                var status = _investigationRepository.GetStatusById(report.StatusId);
                if (status != null)
                {
                    model.Status = new StatusViewModel()
                    {
                        Id = status.Id,
                        Name = status.Name
                    };
                }


                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }

        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            try
            {
                var categoryList = _reportRepository.getAllCategories().Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();

                var model = new CreateReportViewModel()
                {
                    Categories = categoryList,
                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Title, Description, Location, DateSpotted, CategoryId, ImageToUpload")] CreateReportViewModel newReport)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string fileName = "";
                    if (newReport.ImageToUpload != null)
                    {
                        var extension = "." + newReport.ImageToUpload.FileName.Split('.')[newReport.ImageToUpload.FileName.Split('.').Length - 1];
                        fileName = Guid.NewGuid().ToString() + extension;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UserContent", "Images", fileName);
                        using (var bits = new FileStream(path, FileMode.Create))
                        {
                            newReport.ImageToUpload.CopyTo(bits);
                        }
                    }

                    Report report = new Report()
                    {
                        Title = newReport.Title,
                        Description = newReport.Description,
                        Location = newReport.Location,
                        DateSpotted = newReport.DateSpotted,
                        DateOfReport = DateTime.Now,
                        CategoryId = newReport.CategoryId,
                        StatusId = 1,
                        CreatedByUserId = _userManager.GetUserId(User)
                    };

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        report.ImageUrl = "/UserContent/Images/" + fileName;
                    }

                    _reportRepository.AddReport(report);
                    return RedirectToAction("Index");
                }
                else
                {
                    var categoryList = _reportRepository.getAllCategories().Select(c => new CategoryViewModel()
                    {
                        Id = c.Id,
                        Name = c.Name
                    }).ToList();

                    newReport.Categories = categoryList;

                    return View(newReport);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }



        [HttpGet]
        [Authorize]
        public IActionResult EditReport(int id)
        {
            try
            {
                var oldReport = _reportRepository.GetReportById(id);
                if (oldReport != null)
                {
                    var currentUserId = _userManager.GetUserId(User);
                    if (oldReport.CreatedByUserId == currentUserId)
                    {
                        EditReportViewModel model = new EditReportViewModel()
                        {
                            Id = oldReport.Id,
                            Description = oldReport.Description,
                            ImageUrl = oldReport.ImageUrl
                        };

                        return View(model);
                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }



        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult EditReport([FromRoute] int id, [Bind("ImageToUpload, Description, DateOfReport")] EditReportViewModel newReport)
        {
            try
            {
                Report oldReport = _reportRepository.GetReportById(id);

                if (oldReport == null)
                {
                    return NotFound();
                }

                var currentUserId = _userManager.GetUserId(User);
                if (oldReport.CreatedByUserId == currentUserId)
                {
                    if (ModelState.IsValid)
                    {
                        string imageUrl = "";

                        if (newReport.ImageToUpload != null)
                        {
                            string fileName = "";
                            var extension = "." + newReport.ImageToUpload.FileName.Split('.')[newReport.ImageToUpload.FileName.Split('.').Length - 1];
                            fileName = Guid.NewGuid().ToString() + extension;
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
                            using (var bits = new FileStream(path, FileMode.Create))
                            {
                                newReport.ImageToUpload.CopyTo(bits);
                            }
                            imageUrl = "/images/" + fileName;
                        }
                        else
                        {
                            imageUrl = oldReport.ImageUrl;
                        }

                        oldReport.Description = newReport.Description;
                        oldReport.ImageUrl = imageUrl;
                        oldReport.DateOfReport = DateTime.Now;

                        _reportRepository.EditReport(oldReport);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(newReport);
                    }
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpPost]
        [Authorize]
        public IActionResult DeleteReport(int reportId)
        {
            try
            {
                Report report = _reportRepository.GetReportById(reportId);
                
            if (report == null)
                {
                    return NotFound();
                }
                
            string loggedInUserId = _userManager.GetUserAsync(User).Result.Id; 
    
            // Check if the report was created by the same user who is currently logged in
            if (report.CreatedByUserId != loggedInUserId)
            {
               
                return Unauthorized(); // User is not authorized to delete the report
            }

            _reportRepository.DeleteReport(reportId);

            return RedirectToAction("Index");
                

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> VoteAsync(int reportId)
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);

                var hasUpvoted = _reportRepository.HasUpvoted(user.Id, reportId);

                if (hasUpvoted)
                {
                    _reportRepository.RemoveUpvote(user.Id, reportId);
                }
                else
                {
                    _reportRepository.Upvote(user.Id, reportId);
                }

                return RedirectToAction("Details", "Reports", new { id = reportId });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        [HttpGet]
        [Authorize(Roles = "Investigator")]
        public IActionResult CreateInvestigation(int id)
        {
            try
            {
                Report report = _reportRepository.GetReportById(id);

                if (report == null)
                {
                    return NotFound();
                }

                var statusList = _investigationRepository.GetAllStatuses().Select(c => new StatusViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();

                var model = new EditInvestigationViewModel
                {
                    ReportId = report.Id,
                    Statuses = statusList
                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Investigator")]
        public async Task<IActionResult> CreateInvestigation(int id, [Bind("DateOfAction, Description, StatusId")] EditInvestigationViewModel newInvestigation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Investigation investigation = new Investigation()
                    {
                        Description = newInvestigation.Description,
                        DateOfAction = newInvestigation.DateOfAction,
                        InvestigatorId = _userManager.GetUserId(User),
                        StatusId = newInvestigation.StatusId
                    };

                    _investigationRepository.AddInvestigation(id, investigation);

                    Report r = _reportRepository.GetReportById(id);

                    await _emailSender.SendEmailAsync(r.CreatedByUser.Email, "New Investigation on your report", "An investigator has added an investigation to your report \"" + r.Title + "\"");

                    return RedirectToAction("Index");
                }
                else
                {
                    return View(newInvestigation);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> InvestigationAsync(int id)
        {
            try
            {
                var investigation = _investigationRepository.GetInvestigationById(id);

                if (investigation == null)
                    return NotFound();

                var investigatorUsername = await _investigationRepository.GetInvestigatorNameAsync(id);

                var model = new InvestigationViewModel()
                {
                    DateOfAction = DateTime.Now,
                    Description = investigation.Description,
                    InvestigatorId = investigation.InvestigatorId,
                    InvestigatorUsername = investigatorUsername,
                    PreviousVersion = investigation.PreviousVersion,
                    ReportId = _investigationRepository.getReportIdByInvestigation(id)
                };

                var status = _investigationRepository.GetStatusById(investigation.StatusId);
                if (status != null)
                {
                    model.Status = new StatusViewModel()
                    {
                        Id = status.Id,
                        Name = status.Name
                    };
                }

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        [HttpGet]
        [Authorize]
        [Authorize(Roles = "Investigator")]
        public async Task<IActionResult> EditInvestigation(int id)
        {
            try
            {
                Report report = _reportRepository.GetReportById(id);
                Investigation oldInvestigation = _investigationRepository.GetInvestigationById((int)report.InvestigationId);

                if (report == null)
                {
                    return NotFound();
                }

                var statusList = _investigationRepository.GetAllStatuses().Select(c => new StatusViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();

                var model = new EditInvestigationViewModel
                {
                    ReportId = report.Id,
                    Statuses = statusList,
                    Description = oldInvestigation.Description,
                    StatusId = oldInvestigation.StatusId
                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Investigator")]
        public async Task<IActionResult> EditInvestigation([Bind("DateOfAction, Description, StatusId")] EditInvestigationViewModel newInvestigation, int reportId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Investigation investigation = new Investigation()
                    {
                        Description = newInvestigation.Description,
                        DateOfAction = newInvestigation.DateOfAction,
                        InvestigatorId = _userManager.GetUserId(User),
                        StatusId = newInvestigation.StatusId,
                    };

                    _investigationRepository.AddInvestigation(reportId, investigation);

                    Report report = _reportRepository.GetReportById(reportId);
                    await _emailSender.SendEmailAsync(report.CreatedByUser.Email, "Edited Investigation on your report", "An investigator has edited an investigation to your report \"" + report.Title + "\"");

                    return RedirectToAction("Index");
                }
                else
                {
                    return View(newInvestigation);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }
    }
}
