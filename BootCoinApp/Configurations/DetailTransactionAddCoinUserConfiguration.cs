using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class DetailTransactionAddCoinUserConfiguration : IEntityTypeConfiguration<DetailTransactionAddCoinUser>
    {
        public void Configure(EntityTypeBuilder<DetailTransactionAddCoinUser> builder)
        {
            builder.HasKey(x => new
            {
                x.TransactionAddCoinUserId,
                x.AddCoinId,
                x.UserId
            });

            builder.HasOne(x => x.User)
                .WithMany(x => x.DetailTransactionAddCoinUsers)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.HeaderTransactionAddCoinUser)
                .WithMany(x => x.DetailTransactionAddCoinUsers)
                .HasForeignKey(x => x.TransactionAddCoinUserId);

            builder.HasOne(x => x.AddCoinCategory)
                .WithMany(x => x.DetailTransactionAddCoinUsers)
                .HasForeignKey(x => x.AddCoinId);

        }
    }
}
