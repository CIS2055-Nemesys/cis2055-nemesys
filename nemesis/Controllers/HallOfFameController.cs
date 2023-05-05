using Microsoft.AspNetCore.Mvc;
using nemesis.Models.Interfaces;
using nemesis.Models.Repositories;
using nemesis.ViewModels;

namespace nemesis.Controllers
{
    public class HallOfFameController : Controller
    {

        public HallOfFameController(/*IUserRepository userRepository*/)
        {
//            _userRepository = userRepository;
        }

        /*public IActionResult Index()
        {
            var topUsers = _userRepository.GetTop3Reporters();
            var model = new HallOfFameViewModel()
            {
                TopUsers = topUsers.Count(),
                Users = topUsers
            };
            return View(model);
        }*/
    }
}

