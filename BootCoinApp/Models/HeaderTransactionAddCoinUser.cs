using System.ComponentModel.DataAnnotations.Schema;

namespace BootCoinApp.Models
{
    public class HeaderTransactionAddCoinUser
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public DateTime? Date { get; set; }
        public ICollection<DetailTransactionAddCoinUser> DetailTransactionAddCoinUsers { get; set; }
    }
}
