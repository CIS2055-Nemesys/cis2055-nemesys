using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nemesis.Models;
using nemesis.Models.Interfaces;
using nemesis.ViewModels;

namespace nemesis.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IReportRepository _reportRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public ReportsController(IReportRepository reportRepository,UserManager<IdentityUser> userManager)
        {
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
                    Status = report.Status,
                    InvestigationId = report.InvestigationId,
                    Upvotes = report.Upvotes                    
                };

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
                Categories = categoryList
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
                    Status = false,
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
        public IActionResult Investigation(int reportId)
        {
            var model = new InvestigationViewModel();
            return View(model);
        }
    }
}
