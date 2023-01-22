using BootCoinApp.Interfaces;
using BootCoinApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BootCoinApp.Controllers
{
    public class RewardController : Controller
    {
        private readonly IRewardRepository _rewardRepository;

        public RewardController(IRewardRepository rewardRepository)
        {
            _rewardRepository = rewardRepository;
        }
        public async Task<IActionResult> Index(int id, string query = "")
        {
            (CategoryReward, IEnumerable<Reward>) models = await _rewardRepository.GetAllByCategory(id, query);
            return View(models);
        }
        public async Task<IActionResult> Create(int id)
        {
            Reward reward = await _rewardRepository.GetRewardByCategoryId(id);
            ViewData["categoryName"] = reward.CategoryReward.Name;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(int id, Reward reward)
        {
            if (!ModelState.IsValid)
            {
                Reward r = await _rewardRepository.GetRewardByCategoryId(id);
                ViewData["categoryName"] = r.CategoryReward.Name;
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
