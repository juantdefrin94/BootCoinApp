using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class AddCoinCategoryConfiguration : IEntityTypeConfiguration<AddCoinCategory>
    {
        public void Configure(EntityTypeBuilder<AddCoinCategory> builder)
        {
            builder.Property(x => x.AddCoinCategoryName)
                .IsRequired();

            builder.Property(x => x.RequiredCoin)
                .IsRequired();

            builder.Property(x => x.Photo)
                .IsRequired();

            builder.HasMany(x => x.DetailTransactionAddCoinUsers)
                .WithOne(x => x.AddCoinCategory)
                .HasForeignKey(x => x.AddCoinId);

            builder.HasMany(x => x.DetailTransactionAddCoinGroups)
                .WithOne(x => x.AddCoinCategory)
                .HasForeignKey(x => x.AddCoinId);
        }
    }
}
