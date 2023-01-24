using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class RewardConfiguration : IEntityTypeConfiguration<Reward> 
    {
        public void Configure(EntityTypeBuilder<Reward> builder)
        {
            builder.Property(x => x.RewardName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.RewardDescription)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(x => x.RequiredCoin)
                .IsRequired();

            builder.Property(x => x.Photo)
                .IsRequired();

            builder.HasMany(x => x.TransactionRewards)
                .WithOne(x => x.Reward)
                .HasForeignKey(x => x.RewardId);

            builder.HasOne(x => x.CategoryReward)
                .WithMany(x => x.Rewards)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
