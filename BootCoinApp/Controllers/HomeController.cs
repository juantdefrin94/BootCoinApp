using BootCoinApp.Data;
using BootCoinApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var category_rewards = _context.CategoryRewards.ToList();
            return View(category_rewards);
        }
        public IActionResult DetailReward(int id)
        {
            CategoryReward categoryReward = _context.CategoryRewards.Include(cr => cr.Rewards).SingleOrDefault(cr => cr.Id == id);

            if (categoryReward == null)
            {
                return NotFound();
            }

            return View(categoryReward);
        }

        [HttpPost]
        public IActionResult AddMoreReward()
        {
            return RedirectToAction("DetailReward");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}