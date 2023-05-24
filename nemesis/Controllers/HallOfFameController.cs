using Microsoft.AspNetCore.Mvc;
using nemesis.Models.Interfaces;
using nemesis.Models.Repositories;
using nemesis.ViewModels;

namespace nemesis.Controllers
{
    public class HallOfFameController : Controller
    {
        private readonly IHallOfFameRepository _hallOfFameRepository;
        private readonly ILogger _logger;

        public HallOfFameController(IHallOfFameRepository hallOfFameRepository, ILogger<HallOfFameController> logger)
        {
            _hallOfFameRepository = hallOfFameRepository;
            _logger = logger;
        }

        //Fires a method to populate the Hall of Fame with the three reporters with the most reports for the current year, also displaying their most upvoted report of all time
        public IActionResult Index()
        {
            try
            {
                var topUsers = _hallOfFameRepository.GetTop3Reporters();
                var model = new HallOfFameViewModel()
                {
                    TopUsers = topUsers.Count(),
                    Users = topUsers
                };
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

    }
}

