namespace BootCoinApp.Models
{
    public class GroupUser
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int Bootcoin { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<DetailTransactionAddCoinGroup> DetailTransactionAddCoinGroups { get; set; }
    }
}
