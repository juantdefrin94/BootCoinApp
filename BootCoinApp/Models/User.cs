namespace BootCoinApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public GroupUser GroupUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Bootcoin { get; set; }
        public string Photo { get; set; }
        public ICollection<DetailAddCoinUser> DetailAddCoinUsers { get; set; }
        public ICollection<DetailRewardUser> DetailRewardUsers { get; set; }
    }
}
