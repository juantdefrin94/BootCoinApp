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
        public async Task<IActionResult> Index(int categoryId, string categoryName, string query = "")
        {
            //(CategoryReward, IEnumerable<Reward>) models = await _rewardRepository.GetAllByCategory(id, query);
            IEnumerable<Reward> rewards = await _rewardRepository.GetRewardsByCategoryId(categoryId, query);
            ViewData["categoryID"] = categoryId;
            ViewData["categoryName"] = categoryName;
            return View(rewards);
        }
        public IActionResult Create(int categoryId, string categoryName)
        {
            //Reward reward = await _rewardRepository.GetRewardByCategoryId(id);
            //ViewData["categoryName"] = reward.CategoryReward.Name;
            Reward reward = new()
            {
                CategoryId = categoryId
            };
            ViewData["categoryName"] = categoryName;
            ViewData["categoryID"] = categoryId;
            return View(reward);
        }

        [HttpPost]
        public IActionResult Create(int categoryId, string categoryName, Reward reward, IFormFile Photo)
        {
            if (Photo != null && Photo.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(Photo.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
                reward.Photo = fileName;
                TryValidateModel(reward);
            }
            if (!ModelState.IsValid)
            {
                Reward r = new()
                {
                    CategoryId = categoryId
                };
                ViewData["categoryName"] = categoryName;
                ViewData["categoryID"] = categoryId;
                //Reward r = await _rewardRepository.GetRewardByCategoryId(reward.CategoryId);
                //ViewData["categoryName"] = r.CategoryReward.Name;
                //ViewData["categoryID"] = r.CategoryReward.Id;
                return View(r);
            }
            _rewardRepository.Add(reward);
            return RedirectToAction("Index", new { categoryId, categoryName});
        }
    }
}
