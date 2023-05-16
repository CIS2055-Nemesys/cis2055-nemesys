using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nemesis.Migrations;
using nemesis.Models;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;
using nemesis.Models.Repositories;
using nemesis.ViewModels;
using System.Composition;
using System.Diagnostics;

namespace nemesis.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IReportRepository _reportRepository;
        private readonly IInvestigationRepository _investigationRepository;

        private readonly UserManager<IdentityUser> _userManager;

        public ReportsController(
            IReportRepository reportRepository,
            UserManager<IdentityUser> userManager,
            IInvestigationRepository investigationRepository
            )
        {
            _investigationRepository = investigationRepository;
            _reportRepository = reportRepository;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var reports = _reportRepository.getAllReports();
            var model = new ReportsListViewModel()
            {
                TotalReports = reports.Count(),
                Reports = reports
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var report = _reportRepository.GetReportById(id);
            if (report == null)
                return NotFound();
            else
            {
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

        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            //Load all categories and create a list of CategoryViewModel
            var categoryList = _reportRepository.getAllCategories().Select(c => new CategoryViewModel()
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();


            //Pass the list into an EditReportViewModel, which is used by the View (all other properties may be left blank, unless you want to add other default values
            var model = new CreateReportViewModel()
            {
                Categories = categoryList,
            };

            //Pass model to View
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Title, Description, Location, DateSpotted,CategoryId,ImageToUpload")] CreateReportViewModel newReport)
        {
            if (ModelState.IsValid)
            {
                string fileName = "";
                if (newReport.ImageToUpload != null)
                {
                    //At this point you should check size, extension etc...
                    //Then persist using a new name for consistency (e.g. new Guid)
                    var extension = "." + newReport.ImageToUpload.FileName.Split('.')[newReport.ImageToUpload.FileName.Split('.').Length - 1];
                    fileName = Guid.NewGuid().ToString() + extension;
                    var path = Directory.GetCurrentDirectory() + "\\wwwroot\\UserContent\\Images\\" + fileName;
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
                    ImageUrl = "/UserContent/Images/" + fileName,
                    CategoryId = newReport.CategoryId,
                    StatusId = 1,
                    CreatedByUserId = _userManager.GetUserId(User)
                };

                _reportRepository.AddReport(report);
                return RedirectToAction("Index");
            }
            else
            {
                //Load all categories and create a list of CategoryViewModel
                var categoryList = _reportRepository.getAllCategories().Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();

                //Re-attach to view model before sending back to the View (this is necessary so that the View can repopulate the drop down and pre-select according to the CategoryId
                newReport.Categories = categoryList;

                return View(newReport);
            }
        }


        [HttpGet]
        [Authorize]
        public IActionResult EditReport(int id)
        {
            var oldReport = _reportRepository.GetReportById(id);
            if (oldReport != null)
            {
                //Checking for ownership
                var currentUserId = _userManager.GetUserId(User);
                if (oldReport.CreatedByUserId == currentUserId)
                {

                    EditReportViewModel model = new EditReportViewModel()
                    {
                        Id = oldReport.Id,
                        Description = oldReport.Description,
                        ImageUrl = oldReport.ImageUrl,
                    };

                   
                    return View(model);
                }
                else
                    return RedirectToAction("Index");  //or return Forbid()
            }
            else
                return RedirectToAction("Index");
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult EditReport([FromRoute] int id, [Bind("ImageToUpload, Description, DateOfReport")] EditReportViewModel newReport)
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
                        //At this point you should check size, extension etc...
                        //Then persist using a new name for consistency (e.g. new Guid)
                        var extension = "." + newReport.ImageToUpload.FileName.Split('.')[newReport.ImageToUpload.FileName.Split('.').Length - 1];
                        fileName = Guid.NewGuid().ToString() + extension;
                        var path = Directory.GetCurrentDirectory() + "\\wwwroot\\images\\" + fileName;
                        using (var bits = new FileStream(path, FileMode.Create))
                        {
                            newReport.ImageToUpload.CopyTo(bits);
                        }
                        imageUrl = "/images/" + fileName;
                    }
                    else
                    
                        imageUrl = oldReport.ImageUrl;

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
    

        [HttpGet]
        [Authorize (Roles = "Investigator")]
        public IActionResult CreateInvestigation(int id)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Investigator")]
        public IActionResult CreateInvestigation([FromRoute] int id, [Bind("DateOfAction, Description, StatusId")] EditInvestigationViewModel newInvestigation)
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
                return RedirectToAction("Index");
            }
            else
            {
                return View(newInvestigation);
            }
        }

        [HttpGet]
        public async Task<IActionResult> InvestigationAsync(int id)
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
                InvestigatorUsername = investigatorUsername ,
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
    

        [HttpGet]
        [Authorize]
        [Authorize(Roles = "Investigator")]
        public IActionResult EditInvestigation(int id)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Investigator")]
        public IActionResult EditInvestigation([Bind("DateOfAction, Description, StatusId")] EditInvestigationViewModel newInvestigation, int reportId)
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
                return RedirectToAction("Index");
            }
            else
            {
                return View(newInvestigation);
            }
        }
    }
}
