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

        public ReportsController(IReportRepository reportRepository,UserManager<IdentityUser> userManager, IInvestigationRepository investigationRepository)
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
            var model = new EditReportViewModel()
            {
                Categories = categoryList,
            };

            //Pass model to View
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Title, Description, Location, DateSpotted,CategoryId,ImageToUpload")] EditReportViewModel newReport)
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
                    DateOfReport = DateTime.UtcNow,
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
        public IActionResult CreateInvestigation(int Id)
        {
            // Retrieve the report from your data source based on the reportId
            Report report = _reportRepository.GetReportById(Id);

            var statusList = _investigationRepository.GetAllStatuses().Select(c => new StatusViewModel()
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();

            if (report == null)
            {
                // Handle the case where the report is not found
                return NotFound();
            }

            var model = new EditInvestigationViewModel
            {
                ReportId = Id,
                Statuses = statusList

            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateInvestigation([Bind("DateOfAction, Description, StatusId")] EditInvestigationViewModel newInvestigation, int reportId)
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

                _investigationRepository.AddInvestigation(reportId, investigation);
                return RedirectToAction("Index");
            }
            else
            {
                return View(newInvestigation);
            }
        }

        public async Task<IActionResult> InvestigationAsync(int id)
        {
            var investigation = _investigationRepository.GetInvestigationById(id);
            var investigator = await _userManager.FindByIdAsync(investigation.InvestigatorId);
            var investigatorUsername = investigator != null ? investigator.UserName : "Unknown";

            if (investigation == null)
                return NotFound();
            else
            {
                var model = new InvestigationViewModel()
                {
                    DateOfAction = investigation.DateOfAction,
                    Description = investigation.Description,
                    InvestigatorId = investigation.InvestigatorId,
                    InvestigatorUsername = investigatorUsername

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
        }
    }
}
