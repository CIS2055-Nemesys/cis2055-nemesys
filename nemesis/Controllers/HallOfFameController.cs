using Microsoft.AspNetCore.Mvc;
using nemesis.Models.Interfaces;
using nemesis.ViewModels;

namespace nemesis.Controllers
{
    public class HallOfFameController : Controller
    {
        private readonly IReportRepository _reportRepository;

        public HallOfFameController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public IActionResult Index()
        {
            var reports = _reportRepository.GetTop3Reports();
            var model = new HallOfFameViewModel()
            {
                TopReports = reports.Count(),
                Reports = reports
            };
            return View(model);
        }
    }
}

