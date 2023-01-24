using BootCoinApp.Data;
using BootCoinApp.Interfaces;
using BootCoinApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BootCoinApp.Controllers
{
    public class CategoryRewardController : Controller
    {
        private readonly ILogger<CategoryRewardController> _logger;
        private readonly ICategoryRewardRepository _categoryRewardRepository;

        public CategoryRewardController(ILogger<CategoryRewardController> logger, ICategoryRewardRepository categoryRewardRepository)
        {
            _logger = logger;
            _categoryRewardRepository = categoryRewardRepository;
        }

        public async Task<IActionResult> Index(string query = "")
        {
            IEnumerable<CategoryReward> category_rewards = await _categoryRewardRepository.GetAll(query);
            return View(category_rewards);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}