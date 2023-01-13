namespace BootCoinApp.Models
{
    public class AddCoin
    {
        public int Id { get; set; }
        public string AddCoinName { get; set; }
        public int RequiredCoin { get; set; }
        public string Photo { get; set; }
        public ICollection<DetailTransactionAddCoinGroup> DetailTransactionAddCoinGroups { get; set;}
        public ICollection<DetailTransactionAddCoinUser> DetailTransactionAddCoinUsers { get; set;}
    }
}
