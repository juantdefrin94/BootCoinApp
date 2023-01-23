using BootCoinApp.Models;

namespace BootCoinApp.Interfaces
{
    public interface IRewardRepository
    {
        Task<(CategoryReward, IEnumerable<Reward>)> GetAllByCategory(int id, string query = "");
        Task<Reward> GetRewardByCategoryId(int id);
        Task<IEnumerable<Reward>> GetRewardsByCategoryId(int id);
        bool Add(Reward reward);
        bool Delete(Reward reward);
        bool Update(Reward reward);
        bool Save();
    }
}
