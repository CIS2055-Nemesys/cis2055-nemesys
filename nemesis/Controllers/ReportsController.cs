using Microsoft.AspNetCore.Mvc;
using nemesis.Models.Interfaces;
using nemesis.ViewModels;

namespace nemesis.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IReportRepository _reportRepository;

        public ReportsController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
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

        [HttpGet]
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
        public IActionResult Create([Bind("Title, Content, ImageToUpload, CategoryId")] EditReportViewModel newBlogPost)
        {
            if (ModelState.IsValid)
            {
                string fileName = "";
                if (newBlogPost.ImageToUpload != null)
                {
                    //At this point you should check size, extension etc...
                    //Then persist using a new name for consistency (e.g. new Guid)
                    var extension = "." + newBlogPost.ImageToUpload.FileName.Split('.')[newBlogPost.ImageToUpload.FileName.Split('.').Length - 1];
                    fileName = Guid.NewGuid().ToString() + extension;
                    var path = Directory.GetCurrentDirectory() + "\\wwwroot\\images\\blogposts\\" + fileName;
                    using (var bits = new FileStream(path, FileMode.Create))
                    {
                        newBlogPost.ImageToUpload.CopyTo(bits);
                    }
                }

                BlogPost blogPost = new BlogPost()
                {
                    Title = newBlogPost.Title,
                    Content = newBlogPost.Content,
                    CreatedDate = DateTime.UtcNow,
                    ImageUrl = "/images/blogposts/" + fileName,
                    CategoryId = newBlogPost.CategoryId
                };

                _bloggyRepository.CreateBlogPost(blogPost);
                return RedirectToAction("Index");
            }
            else
            {
                //Load all categories and create a list of CategoryViewModel
                var categoryList = _bloggyRepository.GetAllCategories().Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();

                //Re-attach to view model before sending back to the View (this is necessary so that the View can repopulate the drop down and pre-select according to the CategoryId
                newBlogPost.CategoryList = categoryList;

                return View(newBlogPost);
            }


        }
    }
}
