using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class TransactionTypeConfiguration : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder) 
        {
            builder.Property(x => x.TransactionTypeName)
                .IsRequired();

            builder.HasMany(x => x.TransactionRewards)
                .WithOne(x => x.TransactionType)
                .HasForeignKey(x => x.TransactionTypeId);

            builder.HasMany(x => x.HeaderTransactionAddCoinUsers)
                .WithOne(x => x.TransacationType)
                .HasForeignKey(x => x.TransactionTypeId);

            builder.HasMany(x => x.HeaderTransactionAddCoinGroups)
                .WithOne(x => x.TransactionType)
                .HasForeignKey(x => x.TransactionTypeId);
        }
    }
}
