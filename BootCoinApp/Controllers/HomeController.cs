using BootCoinApp.Data;
using BootCoinApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BootCoinApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult AddReward()
        {
            return View();
        }

        public IActionResult AddCoin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}