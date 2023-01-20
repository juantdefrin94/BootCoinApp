using BootCoinApp.Configurations;
using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCoinApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AddCoinCategory> AddCoinCategories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CategoryReward> CategoryRewards { get; set; }
        public DbSet<DetailTransactionAddCoinGroup> DetailTransactionAddCoinGroups { get; set; }
        public DbSet<DetailTransactionAddCoinUser> DetailTransactionAddCoinUsers { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<HeaderTransactionAddCoinGroup> HeaderTransactionAddCoinGroups { get; set; }
        public DbSet<HeaderTransactionAddCoinUser> HeaderTransactionAddCoinUsers { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<TransactionReward> TransactionRewards { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddCoinCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryRewardConfiguration());
            modelBuilder.ApplyConfiguration(new DetailTransactionAddCoinGroupConfiguration());
            modelBuilder.ApplyConfiguration(new DetailTransactionAddCoinUserConfiguration());
            modelBuilder.ApplyConfiguration(new GroupUserConfiguration());
            modelBuilder.ApplyConfiguration(new HeaderTransactionAddCoinGroupConfiguration());
            modelBuilder.ApplyConfiguration(new HeaderTransactionAddCoinUserConfiguration());
            modelBuilder.ApplyConfiguration(new RewardConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionRewardConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
