using Microsoft.AspNetCore.Mvc;
using nemesis.Models.Interfaces;
using nemesis.Models.Repositories;
using nemesis.ViewModels;

namespace nemesis.Controllers
{
    public class HallOfFameController : Controller
    {
        private readonly IHallOfFameRepository _hallOfFameRepository;

        public HallOfFameController(IHallOfFameRepository hallOfFameRepository)
        {
            _hallOfFameRepository = hallOfFameRepository;
        }

        public IActionResult Index()
        {
            var topUsers = _hallOfFameRepository.GetTop3Reporters();
            var model = new HallOfFameViewModel()
            {
                TopUsers = topUsers.Count(),
                Users = topUsers
            };
            return View(model);
        }

    }
}

