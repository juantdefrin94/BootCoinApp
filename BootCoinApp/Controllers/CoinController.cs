using BootCoinApp.Data;
using BootCoinApp.Models;
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
            List<User> users = _context.Users.ToList();

            return View(users);
        }
    }
}
