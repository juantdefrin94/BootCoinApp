namespace BootCoinApp.Models
{
    public class HeaderTransactionReward
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int AdminId { get; set; }
        public string TransactionName { get; set; }
        public DateTime? Date { get; set; }
        public ICollection<DetailTransactionReward> DetailTransactionRewards { get; set; }
    }
}
