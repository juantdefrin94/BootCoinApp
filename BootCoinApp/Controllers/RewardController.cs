using BootCoinApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BootCoinApp.Controllers
{
    public class RewardController : Controller
    {
        private readonly AppDbContext _context;
        public RewardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult AddReward()
        {
            var rewards = _context.Rewards.ToList();
            return View(rewards);
        }
    }
}
