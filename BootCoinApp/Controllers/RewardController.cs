using Microsoft.AspNetCore.Mvc;

namespace BootCoinApp.Controllers
{
    public class RewardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
