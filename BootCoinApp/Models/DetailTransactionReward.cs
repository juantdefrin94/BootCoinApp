namespace BootCoinApp.Models
{
    public class DetailTransactionReward
    {
        public int TransactionRewardId { get; set; }
        public HeaderTransactionReward HeaderTransactionReward { get; set; }
        public int RewardId { get; set; }
        public Reward Reward { get; set; }
        public int TemplateCoinId { get; set; }
        public int RewardQty { get; set; }
    }
}
