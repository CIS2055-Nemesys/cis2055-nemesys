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
using nemesis.Services;
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
        private readonly ILogger<ReportsController> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ReportsController(
            IReportRepository reportRepository,
            UserManager<IdentityUser> userManager,
            IInvestigationRepository investigationRepository,
            ILogger<ReportsController> logger,
            IEmailSender emailSender
        {
            _reportRepository = reportRepository;
            _investigationRepository = investigationRepository;
            _userManager = userManager;
            _logger = logger;
            _emailSender = emailSender;
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
                    Upvotes = report.Upvotes,
                    PhoneNum = report.PhoneNum
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
        public async Task<IActionResult> CreateAsync([Bind("Title, Description, Location, DateSpotted, CategoryId, ImageToUpload")] CreateReportViewModel newReport)
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
                        CreatedByUserId = _userManager.GetUserId(User),
                        PhoneNum = newReport.IncludePhoneNumber ? _userManager.GetUserAsync(User).Result.PhoneNumber : "No phone number available"

                    };

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        report.ImageUrl = "/UserContent/Images/" + fileName;
                    }

                    _reportRepository.AddReport(report);


                    var investigatorEmails = _reportRepository.GetAllInvestigatorEmails();

                    foreach (var e in investigatorEmails)
                    {
                        await _emailSender.SendEmailAsync(e, "A new report is avaiable", "A new report \"" + report.Title + "\" is avaiable for you to investigate");

                    }



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
        public IActionResult Edit(int id)
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
                            ImageUrl = oldReport.ImageUrl,
                            PhoneNum = oldReport.PhoneNum
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
        public IActionResult Edit([FromRoute] int id, [Bind("ImageToUpload, Description, DateOfReport, IncludePhoneNumber")] EditReportViewModel newReport)
        {
            try
            {
                Report report = _reportRepository.GetReportById(id);

                string loggedInUserId = _userManager.GetUserAsync(User).Result.Id;

                if (report.CreatedByUserId != loggedInUserId)
                {
                    return Unauthorized(); // User is not authorized to Edit the report
                }

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
                        if (newReport.IncludePhoneNumber)
                        {
                            oldReport.PhoneNum = newReport.IncludePhoneNumber ? _userManager.GetUserAsync(User).Result.PhoneNumber : "No phone number available";
                        }
                        else
                        {
                            oldReport.PhoneNum = "No phone number available";
                        }

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
        public IActionResult Delete(int reportId)
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


    }
}
