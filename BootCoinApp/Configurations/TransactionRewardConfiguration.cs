using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class TransactionRewardConfiguration : IEntityTypeConfiguration<TransactionReward>
    {
        public void Configure(EntityTypeBuilder<TransactionReward> builder) 
        {
            builder.Property(x => x.Date)
                .IsRequired();

            builder.HasOne(x => x.Admin)
                .WithMany(x => x.TransactionRewards)
                .HasForeignKey(x => x.AdminId);

            builder.HasOne(x => x.User)
                .WithMany(x => x.TransactionRewards)
                .HasForeignKey(x => x.UserId);
        }
    }
}
