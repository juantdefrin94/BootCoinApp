using BootCoinApp.Models;

namespace BootCoinApp.Interfaces
{
    public interface ICategoryRewardRepository
    {
        Task<IEnumerable<CategoryReward>> GetAll(string query = "");
        bool Add(CategoryReward categoryReward);
        bool Delete(CategoryReward categoryReward);
        bool Update(CategoryReward categoryReward);
        bool Save();
    }
}
