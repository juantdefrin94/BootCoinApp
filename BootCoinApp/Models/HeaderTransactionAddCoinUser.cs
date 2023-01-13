using System.ComponentModel.DataAnnotations.Schema;

namespace BootCoinApp.Models
{
    public class HeaderTransactionAddCoinUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public int TransactionTypeId { get; set; }
        public TransactionType TransacationType { get; set; }
        public DateTime? Date { get; set; }
        public ICollection<DetailAddCoinUser> DetailAddCoinUsers { get; set; }
    }
}
