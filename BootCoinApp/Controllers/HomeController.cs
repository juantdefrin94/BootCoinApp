using BootCoinApp.Data;
using BootCoinApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BootCoinApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult AddReward()
        {
            var rewards = _context.Rewards.ToList();
            return View(rewards);
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