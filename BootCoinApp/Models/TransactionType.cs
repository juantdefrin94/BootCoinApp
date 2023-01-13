namespace BootCoinApp.Models
{
    public class TransactionType
    {
        public int TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; }
        public ICollection<HeaderTransactionAddCoinUser> HeaderTransactionAddCoinUsers { get; set; }
        public ICollection<HeaderTransactionReward> HeaderTransactionRewards { get; set; }
    }
}
