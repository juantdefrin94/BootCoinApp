using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class HeaderTransactionAddCoinUserConfiguration : IEntityTypeConfiguration<HeaderTransactionAddCoinUser>
    {
        public void Configure(EntityTypeBuilder<HeaderTransactionAddCoinUser> builder)
        {
            builder.Property(x => x.Date)
                .IsRequired();

            builder.HasMany(x => x.DetailTransactionAddCoinUsers)
                .WithOne(x => x.HeaderTransactionAddCoinUser)
                .HasForeignKey(x => x.TransactionAddCoinUserId);

            builder.HasOne(x => x.Admin)
                .WithMany(x => x.HeaderTransactionAddCoinUsers)
                .HasForeignKey(x => x.AdminId);

            builder.HasOne(x => x.TransacationType)
                .WithMany(x => x.HeaderTransactionAddCoinUsers)
                .HasForeignKey(x => x.TransactionTypeId);
        }
    }
}
