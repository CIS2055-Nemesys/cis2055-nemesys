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
    }
}
