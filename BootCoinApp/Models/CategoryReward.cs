namespace BootCoinApp.Models
{
    public class CategoryReward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Reward> Rewards { get; set; }
    }
}
