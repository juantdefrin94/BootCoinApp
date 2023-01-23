using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootCoinApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddCoinCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddCoinCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredCoin = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddCoinCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryRewards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryRewards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bootcoin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeaderTransactionAddCoinGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderTransactionAddCoinGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeaderTransactionAddCoinGroups_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeaderTransactionAddCoinUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderTransactionAddCoinUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeaderTransactionAddCoinUsers_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rewards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    RewardName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RewardDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RequiredCoin = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rewards_CategoryRewards_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryRewards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bootcoin = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Divisi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_GroupUsers_GroupId",
                        column: x => x.GroupId,
                        principalTable: "GroupUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailTransactionAddCoinGroups",
                columns: table => new
                {
                    TransactionAddCoinGroupId = table.Column<int>(type: "int", nullable: false),
                    AddCoinId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailTransactionAddCoinGroups", x => new { x.TransactionAddCoinGroupId, x.AddCoinId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_DetailTransactionAddCoinGroups_AddCoinCategories_AddCoinId",
                        column: x => x.AddCoinId,
                        principalTable: "AddCoinCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailTransactionAddCoinGroups_GroupUsers_GroupId",
                        column: x => x.GroupId,
                        principalTable: "GroupUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailTransactionAddCoinGroups_HeaderTransactionAddCoinGroups_TransactionAddCoinGroupId",
                        column: x => x.TransactionAddCoinGroupId,
                        principalTable: "HeaderTransactionAddCoinGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailTransactionAddCoinUsers",
                columns: table => new
                {
                    TransactionAddCoinUserId = table.Column<int>(type: "int", nullable: false),
                    AddCoinId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailTransactionAddCoinUsers", x => new { x.TransactionAddCoinUserId, x.AddCoinId, x.UserId });
                    table.ForeignKey(
                        name: "FK_DetailTransactionAddCoinUsers_AddCoinCategories_AddCoinId",
                        column: x => x.AddCoinId,
                        principalTable: "AddCoinCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailTransactionAddCoinUsers_HeaderTransactionAddCoinUsers_TransactionAddCoinUserId",
                        column: x => x.TransactionAddCoinUserId,
                        principalTable: "HeaderTransactionAddCoinUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailTransactionAddCoinUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionRewards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RewardId = table.Column<int>(type: "int", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionRewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionRewards_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionRewards_Rewards_RewardId",
                        column: x => x.RewardId,
                        principalTable: "Rewards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionRewards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailTransactionAddCoinGroups_AddCoinId",
                table: "DetailTransactionAddCoinGroups",
                column: "AddCoinId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTransactionAddCoinGroups_GroupId",
                table: "DetailTransactionAddCoinGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTransactionAddCoinUsers_AddCoinId",
                table: "DetailTransactionAddCoinUsers",
                column: "AddCoinId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTransactionAddCoinUsers_UserId",
                table: "DetailTransactionAddCoinUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HeaderTransactionAddCoinGroups_AdminId",
                table: "HeaderTransactionAddCoinGroups",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_HeaderTransactionAddCoinUsers_AdminId",
                table: "HeaderTransactionAddCoinUsers",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_CategoryId",
                table: "Rewards",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRewards_AdminId",
                table: "TransactionRewards",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRewards_RewardId",
                table: "TransactionRewards",
                column: "RewardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRewards_UserId",
                table: "TransactionRewards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupId",
                table: "Users",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailTransactionAddCoinGroups");

            migrationBuilder.DropTable(
                name: "DetailTransactionAddCoinUsers");

            migrationBuilder.DropTable(
                name: "TransactionRewards");

            migrationBuilder.DropTable(
                name: "HeaderTransactionAddCoinGroups");

            migrationBuilder.DropTable(
                name: "AddCoinCategories");

            migrationBuilder.DropTable(
                name: "HeaderTransactionAddCoinUsers");

            migrationBuilder.DropTable(
                name: "Rewards");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CategoryRewards");

            migrationBuilder.DropTable(
                name: "GroupUsers");
        }
    }
}
