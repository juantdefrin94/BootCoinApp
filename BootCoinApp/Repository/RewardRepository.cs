using BootCoinApp.Data;
using BootCoinApp.Interfaces;
using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCoinApp.Repository
{
    public class RewardRepository : IRewardRepository
    {
        private readonly AppDbContext _context;

        public RewardRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Add(Reward reward)
        {
            _context.Add(reward);
            return Save();
        }

        public bool Delete(Reward reward)
        {
            _context.Remove(reward);
            return Save();
        }

        public async Task<(CategoryReward, IEnumerable<Reward>)> GetAllByCategory(int id, string query = "")
        {
            CategoryReward categoryReward = await _context.CategoryRewards.Include(cr => cr.Rewards)
                .FirstOrDefaultAsync(cr => cr.Id == id);

            if (categoryReward != null) 
            {
                IEnumerable<Reward> rewards = categoryReward.Rewards;
                if (!string.IsNullOrEmpty(query))
                {
                    rewards = rewards.Where(r => r.RewardName.ToLower().Contains(query.ToLower()));
                }
                return ((categoryReward, rewards));
            }
            else
            {
                return default;
            }
        }

        public async Task<Reward> GetRewardByCategoryId(int id)
        {
            return await _context.Rewards.Include(r => r.CategoryReward).FirstOrDefaultAsync(r => r.CategoryId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Reward reward)
        {
            _context.Update(reward);
            return Save();
        }
    }
}
