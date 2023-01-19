using BootCoinApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Net;

namespace BootCoinApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //AddCoinCategories
                if (!context.AddCoinCategories.Any())
                {
                    context.AddCoinCategories.AddRange(new List<AddCoinCategory>()
                    {
                        new AddCoinCategory()
                        {
                            AddCoinCategoryName = "Test 1",
                            RequiredCoin = 1,
                            Photo = "Test 1"
                        }
                    });
                    context.SaveChanges();
                }
                //Admins
                if (!context.Admins.Any())
                {
                    context.Admins.AddRange(new List<Admin>()
                    {
                        new Admin()
                        {
                            Name = "Test 1",
                            Password = "Test123"
                        }
                    });
                    context.SaveChanges();
                }
                //Category Rewards
                if (!context.CategoryRewards.Any())
                {
                    context.CategoryRewards.AddRange(new List<CategoryReward>()
                    {
                        new CategoryReward()
                        {
                            Name = "Test 1"
                        }
                    });
                    context.SaveChanges();
                }
                //Group Users
                if (!context.GroupUsers.Any())
                {
                    context.GroupUsers.AddRange(new List<GroupUser>()
                    {
                        new GroupUser()
                        {
                            GroupName = "A",
                            Bootcoin = 500
                        }
                    });
                    context.SaveChanges();
                }
                //Transaction Types
                if (!context.TransactionTypes.Any())
                {
                    context.TransactionTypes.AddRange(new List<TransactionType>()
                    {
                        new TransactionType()
                        {
                            TransactionTypeName = "Test 1"
                        }
                    });
                    context.SaveChanges();
                }
                //Users
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            GroupId = 1,
                            Email = "test@gmail.com",
                            Password = "test123",
                            Bootcoin = 5,
                            Photo = "test.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //HeaderTransactionAddCoinGroups
                if (!context.HeaderTransactionAddCoinGroups.Any())
                {
                    context.HeaderTransactionAddCoinGroups.AddRange(new List<HeaderTransactionAddCoinGroup>()
                    {
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 1,
                            TransactionTypeId = 1,
                            Date = DateTime.Today
                         },
                    });
                    context.SaveChanges();
                }
                //HeaderTransactionAddCoinUsers
                if (!context.HeaderTransactionAddCoinUsers.Any())
                {
                    context.HeaderTransactionAddCoinUsers.AddRange(new List<HeaderTransactionAddCoinUser>()
                    {
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 1,
                            TransactionTypeId = 1,
                            Date = DateTime.Today
                        }
                    });
                    context.SaveChanges();
                }
                //TransactionRewards
                if (!context.TransactionRewards.Any())
                {
                    context.TransactionRewards.AddRange(new List<TransactionReward>()
                    {
                        new TransactionReward()
                        {
                            UserId = 1,
                            AdminId = 1,
                            TransactionTypeId = 1,
                            RewardQty = 1,
                            Date = DateTime.Today
                        }
                    });
                    context.SaveChanges();
                }
                //DetailTransactionAddCoinGroups
                if (!context.DetailTransactionAddCoinGroups.Any())
                {
                    context.DetailTransactionAddCoinGroups.AddRange(new List<DetailTransactionAddCoinGroup>()
                    {
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 1,
                            AddCoinId = 1,
                            GroupId = 1
                        }
                    });
                    context.SaveChanges();
                }
                //DetailTransactionAddCoinUsers
                if (!context.DetailTransactionAddCoinUsers.Any())
                {
                    context.DetailTransactionAddCoinUsers.AddRange(new List<DetailTransactionAddCoinUser>()
                    {
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 1,
                            AddCoinId = 1,
                            UserId = 1
                        }
                    });
                    context.SaveChanges();
                }
                //Rewards
                if (!context.Rewards.Any())
                {
                    context.Rewards.AddRange(new List<Reward>()
                    {
                        new Reward()
                        {
                            CategoryId = 1,
                            RewardName = "Testing",
                            RewardDescription = "Reward Testing 1",
                            RequiredCoin = 1,
                            Photo = "test.jpg"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new AppUser()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}
    }
}