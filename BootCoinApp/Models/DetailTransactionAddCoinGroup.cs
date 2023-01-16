namespace BootCoinApp.Models
{
    public class DetailTransactionAddCoinGroup
    {
        public int TransactionAddCoinGroupId { get; set; }
        public HeaderTransactionAddCoinGroup HeaderTransactionAddCoinGroup { get; set; }
        public int AddCoinId { get; set; }
        public AddCoinCategory AddCoinCategory { get; set; }
        public int GroupId { get; set; }
        public GroupUser GroupUser { get; set; }
    }
}
