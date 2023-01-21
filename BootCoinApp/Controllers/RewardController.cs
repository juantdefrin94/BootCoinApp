using BootCoinApp.Data;
using BootCoinApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BootCoinApp.Controllers
{
    public class RewardController : Controller
    {
        private readonly ILogger<RewardController> _logger;
        private readonly AppDbContext _context;

        public RewardController(ILogger<RewardController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult AddReward()
        {
            var category_rewards = _context.CategoryRewards.ToList();
            return View(category_rewards);
        }
        public IActionResult DetailReward(int id, string query = "")
        {
            CategoryReward categoryReward = _context.CategoryRewards.Include(cr => cr.Rewards)
                .SingleOrDefault(cr => cr.Id == id && cr.Name.Contains(query));

            //if (categoryReward == null)
            //{
            //    return NotFound("No data lol");
            //}

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