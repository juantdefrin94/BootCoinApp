namespace BootCoinApp.Models
{
    public class DetailTransactionAddCoinUser
    {
        public int TransactionAddCoinUserId { get; set; }
        public HeaderTransactionAddCoinUser HeaderTransactionAddCoinUser { get; set; }
        public int AddCoinId { get; set; }
        public AddCoinCategory AddCoin { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
