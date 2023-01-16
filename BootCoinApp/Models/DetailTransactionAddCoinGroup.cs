namespace BootCoinApp.Models
{
    public class DetailTransactionAddCoinGroup
    {
        public int TransactionAddCoinId { get; set; }
        public HeaderTransactionAddCoinGroup HeaderTransactionAddCoinGroup { get; set; }
        public int AddCoinId { get; set; }
        public AddCoinCategory AddCoin { get; set; }
        public int GroupId { get; set; }
        public GroupUser GroupUser { get; set; }
    }
}
