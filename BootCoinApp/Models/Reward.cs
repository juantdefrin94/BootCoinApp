namespace BootCoinApp.Models
{
    public class Reward
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public CategoryReward CategoryReward { get; set; }
        public string RewardName { get; set; }
        public string RewardDescription { get; set; }
        public int RequiredCoin { get; set; }
        public string Photo { get; set; }
    }
}
