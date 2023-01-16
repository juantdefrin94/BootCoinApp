using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(x => x.Password)
                .IsRequired();

            builder.HasMany(x => x.TransactionRewards)
                .WithOne(x => x.Admin)
                .HasForeignKey(x => x.AdminId);

            builder.HasMany(x => x.HeaderTransactionAddCoinUsers)
                .WithOne(x => x.Admin)
                .HasForeignKey(x => x.AdminId);

            builder.HasMany(x => x.HeaderTransactionAddCoinGroups)
                .WithOne(x => x.Admin)
                .HasForeignKey(x => x.AdminId);
        }
    }
}
