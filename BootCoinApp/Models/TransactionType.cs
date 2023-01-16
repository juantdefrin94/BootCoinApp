namespace BootCoinApp.Models
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string TransactionTypeName { get; set; }
        public ICollection<HeaderTransactionAddCoinUser> HeaderTransactionAddCoinUsers { get; set; }
        public ICollection<TransactionReward> TransactionRewards { get; set; }
        public ICollection<HeaderTransactionAddCoinGroup> HeaderTransactionAddCoinGroups { get; set; }
    }
}
