using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServingSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IngredientsImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carbohydrates = table.Column<double>(type: "float", nullable: false),
                    CarbohydratesUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    CaloriesUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fat = table.Column<double>(type: "float", nullable: false),
                    FatUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FruitAndVegServings = table.Column<double>(type: "float", nullable: false),
                    NovaGroup = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    ProteinUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<double>(type: "float", nullable: false),
                    SaltUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaturatedFat = table.Column<double>(type: "float", nullable: false),
                    SaturatedFatUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sodium = table.Column<double>(type: "float", nullable: false),
                    SodiumUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sugar = table.Column<double>(type: "float", nullable: false),
                    SugarUnit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "FoodItems");
        }
    }
}
