namespace BootCoinApp.Models
{
    public class TransactionReward
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RewardId { get; set; }
        public Reward Reward { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public int TransactionTypeId { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime Date { get; set; }
        public int RewardQty { get; set; }

    }
}
