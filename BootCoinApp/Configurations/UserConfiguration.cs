using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootCoinApp.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FullName)
                .IsRequired();

            builder.Property(x => x.UserName)
                .IsRequired();

            builder.Property(x => x.Email)
                .IsRequired();

            builder.Property(x => x.Password)
                .IsRequired();

            builder.Property(x => x.Bootcoin)
                .IsRequired();

            builder.Property(x => x.Photo)
                .IsRequired();

            builder.Property(x => x.Divisi)
                .IsRequired();

            builder.HasMany(x => x.TransactionRewards)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.GroupUser)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.GroupId);

            builder.HasMany(x => x.DetailTransactionAddCoinUsers)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
        }
    }
}
