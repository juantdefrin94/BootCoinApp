using Microsoft.AspNetCore.Mvc;

namespace BootCoinApp.Controllers
{
    public class TesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
