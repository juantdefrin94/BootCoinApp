using BootCoinApp.Models;

namespace BootCoinApp.Interfaces
{
    public interface ICategoryRewardRepository
    {
        Task<IEnumerable<CategoryReward>> GetAll();
        bool Add(CategoryReward categoryReward);
        bool Delete(CategoryReward categoryReward);
        bool Update(CategoryReward categoryReward);
        bool Save();
    }
}
