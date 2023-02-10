using BootCoinApp.Data;
using BootCoinApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BootCoinApp.Controllers
{
    public class CoinController : Controller
    {
        private readonly AppDbContext _context;
        public CoinController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult CoinPeople()
        {
            List<User> users = _context.Users.ToList();

            return View(users);
        }

        public IActionResult CoinGroup()
        {
            List<GroupUser> groups = _context.GroupUsers.ToList();

            return View(groups);
        }

        public IActionResult CoinSelect()
        {
            List<AddCoinCategory> coins = _context.AddCoinCategories.ToList();
            return View(coins);
        }

        [HttpPost]
        public IActionResult AddCoinToUser(string coins, string tempId)
        {
            var tempList = tempId.Split(",");
            var coinList = coins.Split(",");
            int tempCoins = 0;
            List<User> users = null;
            List<User> usersAll = _context.Users.ToList();
            foreach (var item in coinList)
            {
                tempCoins += int.Parse(item);
            }
            foreach (var item in tempList)
            {
                foreach (var userTemp in usersAll)
                {
                    int x = int.Parse(item);
                    if(userTemp.Id == x)
                    {
                        var user = _context.Users.Where(u => u.Id == x).FirstOrDefault();
                        user.Bootcoin += tempCoins;
                        _context.Update(user);
                        _context.SaveChanges();
                    }
                }
            }
            return RedirectToAction("CoinPeople");
        }
        [HttpPost]
        public IActionResult PassingUser(string temp)
        {
            //var tempList = temp.Split(",");
            ViewData["tempList"] = temp;
            return Redirect("CoinSelect");
        }
    }
}
