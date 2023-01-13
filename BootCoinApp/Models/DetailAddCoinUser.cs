namespace BootCoinApp.Models
{
    public class DetailAddCoinUser
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TransactionAddCoinUserId { get; set; }
        public HeaderTransactionAddCoinUser HeaderTransactionAddCoinUser { get; set; }
        public int UserQty { get; set; }
    }
}
