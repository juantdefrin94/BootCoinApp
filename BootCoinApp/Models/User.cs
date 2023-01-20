namespace BootCoinApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public GroupUser GroupUser { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Bootcoin { get; set; }
        public string Photo { get; set; }
        public string Divisi { get; set; }
        public ICollection<DetailTransactionAddCoinUser> DetailTransactionAddCoinUsers { get; set; }
        public ICollection<TransactionReward> TransactionRewards { get; set; }
    }
}
