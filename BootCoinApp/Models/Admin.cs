namespace BootCoinApp.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public ICollection<HeaderTransactionAddCoinGroup> HeaderTransactionAddCoinGroups { get; set; }
        public ICollection<HeaderTransactionAddCoinUser> HeaderTransactionAddCoinUsers { get; set; }
        public ICollection<TransactionReward> TransactionRewards { get; set; }
    }
}
