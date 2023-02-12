using BootCoinApp.Models;
using CsvHelper;
using System.Reflection;
using System.Text;

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
                            AddCoinCategoryName = "Attendance",
                            RequiredCoin = 3,
                            Photo = "Attendance.jpg"
                        },
                        new AddCoinCategory()
                        {
                            AddCoinCategoryName = "Participation",
                            RequiredCoin = 5,
                            Photo = "Participation.jpg"
                        },
                        new AddCoinCategory()
                        {
                            AddCoinCategoryName = "Mission 1",
                            RequiredCoin = 20,
                            Photo = "Mission1.jpg"
                        },
                        new AddCoinCategory()
                        {
                            AddCoinCategoryName = "Mission 2",
                            RequiredCoin = 20,
                            Photo = "Mission2.jpg"
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
                            Name = "Bryan",
                            Password = "ABC5Dasar"
                        },
                        new Admin()
                        {
                            Name = "Budi",
                            Password = "MukaLu"
                        },
                        new Admin()
                        {
                            Name = "Tono",
                            Password = "MoTauAja"
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
                            Name = "Mentoring Session"
                        },
                        new CategoryReward()
                        {
                            Name = "E-Voucher"
                        },
                        new CategoryReward()
                        {
                            Name = "Merchandise"
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
                        },
                        new GroupUser()
                        {
                            GroupName = "B",
                            Bootcoin = 250
                        },
                        new GroupUser()
                        {
                            GroupName = "C",
                            Bootcoin = 600
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
                            FullName = "Denny Alvito ginting",
                            UserName = "Denny001",
                            Email = "DennyAlvito@gmail.com",
                            Password = "P@ssword1",
                            Bootcoin = 5,
                            Photo = "denny.jpg",
                            Divisi = "CSA"
                        },
                        new User()
                        {
                            GroupId = 1,
                            FullName = "Juan Trilnardo Defrin",
                            UserName = "Juan002",
                            Email = "JuanTrilnardo@gmail.com",
                            Password = "14975Ku@",
                            Bootcoin = 15,
                            Photo = "juan.jpg",
                            Divisi = "CSA"
                        },
                        new User()
                        {
                            GroupId = 1,
                            FullName = "Nico Tandra Jonathan",
                            UserName = "Nico003",
                            Email = "NicoTandra@gmail.com",
                            Password = "31Hp005#",
                            Bootcoin = 20,
                            Photo = "nico.jpg",
                            Divisi = "CSA"
                        },
                        new User()
                        {
                            GroupId = 1,
                            FullName = "Tarish Arifah Ibrahim",
                            UserName = "Tarish004",
                            Email = "TarishArifah@gmail.com",
                            Password = "!Bdakwm23",
                            Bootcoin = 30,
                            Photo = "tarish.jpg",
                            Divisi = "BSA"
                        },
                        new User()
                        {
                            GroupId = 2,
                            FullName = "Feliks Hartanto ",
                            UserName = "Feliks0011",
                            Email = "FeliksHartanto@gmail.com",
                            Password = "KamuNanyak6",
                            Bootcoin = 50,
                            Photo = "Feliks.jpg",
                            Divisi = "CSA"
                        },
                        new User()
                        {
                            GroupId = 2,
                            FullName = "Endrew Rudiyono",
                            UserName = "Endrew0012",
                            Email = "EndrewRudiyono@gmail.com",
                            Password = "BisaAja8",
                            Bootcoin = 55,
                            Photo = "Endrew.jpg",
                            Divisi = "BIA"
                        },
                        new User()
                        {
                            GroupId = 2,
                            FullName = "Raymond Johnson",
                            UserName = "Raymond0013",
                            Email = "RaymondJohnson@gmail.com",
                            Password = "HaiAdek8",
                            Bootcoin = 60,
                            Photo = "Raymond.jpg",
                            Divisi = "CSA"
                        },
                        new User()
                        {
                            GroupId = 2,
                            FullName = "Ivana Jane Semayag",
                            UserName = "Ivana00141",
                            Email = "IvanaJane@gmail.com",
                            Password = "SatuDua3",
                            Bootcoin = 15,
                            Photo = "Ivana.jpg",
                            Divisi = "BIA"
                        },
                        new User()
                        {
                            GroupId = 3,
                            FullName = "Satria Devona Algista",
                            UserName = "Satria0021",
                            Email = "SatriaDevona@gmail.com",
                            Password = "Punya224",
                            Bootcoin = 20,
                            Photo = "Satria.jpg",
                            Divisi = "BSA"
                        },
                        new User()
                        {
                            GroupId = 3,
                            FullName = "Charys Naomi Winarto",
                            UserName = "Charys0022",
                            Email = "CharysNaomi@gmail.com",
                            Password = "Joshh88",
                            Bootcoin = 25,
                            Photo = "Charys.jpg",
                            Divisi = "CSA"
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
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 1,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 2,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 2,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 1,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 3,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 3,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 1,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 3,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinGroup()
                        {
                            AdminId = 1,
                            Date = DateTime.Today
                        }
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
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 1,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 2,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 2,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 1,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 3,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 3,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 1,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 3,
                            Date = DateTime.Today
                        },
                        new HeaderTransactionAddCoinUser()
                        {
                            AdminId = 1,
                            Date = DateTime.Today
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
                            CategoryId = 3,
                            RewardName = "PTFI Polo Shirt",
                            RewardDescription = "Kaos polo lengan pendek basic, cocok untuk segala outfit.",
                            RequiredCoin = 190,
                            Photo = "PTFIPoloShirt.jpg"
                        },
                        new Reward()
                        {
                            CategoryId = 3,
                            RewardName = "PTFI Lanyard",
                            RewardDescription = "Bahan kulit yang dijahit dengan mesin",
                            RequiredCoin = 190,
                            Photo = "PTFILanyard.jpg"
                        },
                        new Reward()
                        {
                            CategoryId = 1,
                            RewardName = "BIA",
                            RewardDescription = "Mentoring langsung BIA",
                            RequiredCoin = 1200,
                            Photo = "mentoring.jpg"
                        },
                        new Reward()
                        {
                            CategoryId = 1,
                            RewardName = "BSA",
                            RewardDescription = "Mentoring langsung BSA",
                            RequiredCoin = 1200,
                            Photo = "mentoring.jpg"
                        },
                        new Reward()
                        {
                            CategoryId = 2,
                            RewardName = "Gopay 20.000",
                            RewardDescription = "Mendapatkan voucher gopay sebesar Rp.20.000",
                            RequiredCoin = 70,
                            Photo = "gopay.png"
                        },
                        new Reward()
                        {
                            CategoryId = 2,
                            RewardName = "Gopay 50.000",
                            RewardDescription = "Mendapatkan voucher gopay sebesar Rp.50.000",
                            RequiredCoin = 200,
                            Photo = "gopay.png"
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
                            RewardId = 1,
                        },
                        new TransactionReward()
                        {
                            UserId = 2,
                            AdminId = 1,
                            RewardId = 2,
                            Date = DateTime.Today
                        },
                        new TransactionReward()
                        {
                            UserId = 3,
                            AdminId = 2,
                            RewardId = 3,
                            Date = DateTime.Today
                        },
                        new TransactionReward()
                        {
                            UserId = 4,
                            AdminId = 3,
                            RewardId = 4,
                            Date = DateTime.Today
                        },
                        new TransactionReward()
                        {
                            UserId = 5,
                            AdminId = 2,
                            RewardId = 5,
                            Date = DateTime.Today
                        },
                        new TransactionReward()
                        {
                            UserId = 6,
                            AdminId = 3,
                            RewardId = 6,
                            Date = DateTime.Today
                        },
                        new TransactionReward()
                        {
                            UserId = 7,
                            AdminId = 2,
                            RewardId = 2,
                            Date = DateTime.Today
                        },
                        new TransactionReward()
                        {
                            UserId = 8,
                            AdminId = 1,
                            RewardId = 1,
                            Date = DateTime.Today
                        },
                        new TransactionReward()
                        {
                            UserId = 9,
                            AdminId = 2,
                            RewardId = 3,
                            Date = DateTime.Today
                        },
                        new TransactionReward()
                        {
                            UserId = 10,
                            AdminId = 1,
                            RewardId = 5,
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
                        },
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 1,
                            AddCoinId = 2,
                            GroupId = 2
                        },
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 1,
                            AddCoinId = 4,
                            GroupId = 3
                        },
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 2,
                            AddCoinId = 1,
                            GroupId = 1
                        },
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 2,
                            AddCoinId = 2,
                            GroupId = 2
                        },
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 2,
                            AddCoinId = 2,
                            GroupId = 1
                        },
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 2,
                            AddCoinId = 3,
                            GroupId = 3
                        },
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 3,
                            AddCoinId = 4,
                            GroupId = 1
                        },
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 3,
                            AddCoinId = 3,
                            GroupId = 3
                        },
                        new DetailTransactionAddCoinGroup()
                        {
                            TransactionAddCoinGroupId = 3,
                            AddCoinId = 2,
                            GroupId = 3
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
                            AddCoinId = 2,
                            UserId = 1
                        },
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 1,
                            AddCoinId = 2,
                            UserId = 5
                        },
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 1,
                            AddCoinId = 2,
                            UserId = 4
                        },
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 2,
                            AddCoinId = 1,
                            UserId = 7
                        },
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 2,
                            AddCoinId = 3,
                            UserId = 9
                        },
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 2,
                            AddCoinId = 4,
                            UserId = 2
                        },
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 2,
                            AddCoinId = 4,
                            UserId = 3
                        },
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 3,
                            AddCoinId = 3,
                            UserId = 7
                        },
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 3,
                            AddCoinId = 1,
                            UserId = 6
                        },
                        new DetailTransactionAddCoinUser()
                        {
                            TransactionAddCoinUserId = 3,
                            AddCoinId = 2,
                            UserId = 5
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}