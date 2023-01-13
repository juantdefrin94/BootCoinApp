namespace BootCoinApp.Models
{
    public class DetailTransactionAddCoinGroup
    {
        public int TransactionAddCoinId { get; set; }
        public HeaderTransactionAddCoinGroup HeaderTransactionAddCoinGroup { get; set; }
        public int AddCoinId { get; set; }
        public AddCoin AddCoin { get; set; }
        public int TemplateCoindId { get; set; }
        public int BootcoinQty { get; set; }
    }
}
