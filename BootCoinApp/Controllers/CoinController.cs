using BootCoinApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BootCoinApp.Controllers
{
    public class CoinController : Controller
    {
        private readonly AppDbContext _context;
        public CoinController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult AddCoin()
        {
            return View();
        }
    }
}
