namespace BootCoinApp.Models
{
    public class DetailTransactionAddCoinUser
    {
        public int TransactionAddCoinUserId { get; set; }
        public HeaderTransactionAddCoinUser HeaderTransactionAddCoinUser { get; set; }
        public int AddCoinId { get; set; }
        public AddCoin AddCoin { get; set; }
        public int TemplateCoinId { get; set; }
        public int BootcoinQty { get; set; }
    }
}
