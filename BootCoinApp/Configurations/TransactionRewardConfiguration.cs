using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class TransactionRewardConfiguration : IEntityTypeConfiguration<TransactionReward>
    {
        public void Configure(EntityTypeBuilder<TransactionReward> builder) 
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Date)
                .IsRequired();

            builder.Property(x => x.RewardQty)
                .IsRequired();

            builder.HasOne(x => x.Admin)
                .WithMany(x => x.TransactionRewards)
                .HasForeignKey(x => x.AdminId);

            builder.HasOne(x => x.Reward)
                .WithOne(x => x.TransactionReward)
                .HasForeignKey<Reward>(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(x => x.TransactionRewards)
                .HasForeignKey(x => x.UserId);
        }
    }
}
