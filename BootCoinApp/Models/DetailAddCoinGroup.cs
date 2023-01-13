namespace BootCoinApp.Models
{
    public class DetailAddCoinGroup
    {
        public int GroupId { get; set; }
        public GroupUser GroupUser { get; set; }
        public int TransactionAddCoinGroupId { get; set; }
        public HeaderTransactionAddCoinGroup HeaderTransactionAddCoinGroup { get; set; }
        public int GroupQty { get; set; }
    }
}
