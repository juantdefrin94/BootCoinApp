using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class DetailTransactionAddCoinGroupConfiguration : IEntityTypeConfiguration<DetailTransactionAddCoinGroup>
    {
        public void Configure(EntityTypeBuilder<DetailTransactionAddCoinGroup> builder)
        {
            builder.HasKey(x => new
            {
                x.TransactionAddCoinGroupId,
                x.AddCoinId,
                x.GroupId
            });

            builder.HasOne(x => x.GroupUser)
                .WithMany(x => x.DetailTransactionAddCoinGroups)
                .HasForeignKey(x => x.GroupId);

            builder.HasOne(x => x.AddCoinCategory)
                .WithMany(x => x.DetailTransactionAddCoinGroups)
                .HasForeignKey(x => x.AddCoinId);

            builder.HasOne(x => x.HeaderTransactionAddCoinGroup)
                .WithMany(x => x.DetailTransactionAddCoinGroups)
                .HasForeignKey(x => x.TransactionAddCoinGroupId);
        }
    }
}
