using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class HeaderTransactionAddCoinGroupConfiguration : IEntityTypeConfiguration<HeaderTransactionAddCoinGroup>
    {
        public void Configure(EntityTypeBuilder<HeaderTransactionAddCoinGroup> builder)
        {
            builder.Property(x => x.Date)
                .IsRequired();

            builder.HasMany(x => x.DetailTransactionAddCoinGroups)
                .WithOne(x => x.HeaderTransactionAddCoinGroup)
                .HasForeignKey(x => x.TransactionAddCoinGroupId);

            builder.HasOne(x => x.Admin)
                .WithMany(x => x.HeaderTransactionAddCoinGroups)
                .HasForeignKey(x => x.AdminId);
        }
    }
}
