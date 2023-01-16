namespace BootCoinApp.Models
{
    public class AddCoinCategory
    {
        public int Id { get; set; }
        public string AddCoinCategoryName { get; set; }
        public int RequiredCoin { get; set; }
        public string Photo { get; set; } = string.Empty;
        public ICollection<DetailTransactionAddCoinGroup> DetailTransactionAddCoinGroups { get; set;}
        public ICollection<DetailTransactionAddCoinUser> DetailTransactionAddCoinUsers { get; set;}
    }
}
