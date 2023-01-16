using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class CategoryRewardConfiguration : IEntityTypeConfiguration<CategoryReward>
    {
        public void Configure(EntityTypeBuilder<CategoryReward> builder) 
        {
            builder.Property(x => x.Name)
                .IsRequired();

            builder.HasMany(x => x.Rewards)
                .WithOne(x => x.CategoryReward)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
