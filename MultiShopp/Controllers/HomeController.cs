using Microsoft.AspNetCore.Mvc;
using MultiShopp.Models;
using System.Diagnostics;

namespace MultiShopp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
           public IActionResult Shop()
        {
            return View();
        }
           public IActionResult Detail()
        {
            return View();
        }
           public IActionResult Cart()
        {
            return View();
        }

    }
}