namespace BootCoinApp.Models
{
    public class DetailRewardUser
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TransactionRewardId { get; set; }
        public HeaderTransactionReward HeaderTransactionReward { get; set; }
        public int UserQty { get; set; }
    }
}
