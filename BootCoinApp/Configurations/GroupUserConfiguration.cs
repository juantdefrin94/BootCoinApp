using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class GroupUserConfiguration : IEntityTypeConfiguration<GroupUser>
    {
        public void Configure(EntityTypeBuilder<GroupUser> builder)
        {
            builder.Property(x => x.GroupName)
                .IsRequired();

            builder.Property(x => x.Bootcoin)
                .IsRequired();

            builder.HasMany(x => x.Users)
                .WithOne(x => x.GroupUser)
                .HasForeignKey(x => x.GroupId);

            builder.HasMany(x => x.DetailTransactionAddCoinGroups)
                .WithOne(x => x.GroupUser)
                .HasForeignKey(x => x.GroupId);
        }
    }
}
