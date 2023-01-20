using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFoodItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "AppUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ServingSize = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ThumbnailImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    IngredientsImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Carbohydrates = table.Column<double>(type: "REAL", nullable: false),
                    CarbohydratesUnit = table.Column<string>(type: "TEXT", nullable: true),
                    Calories = table.Column<double>(type: "REAL", nullable: false),
                    CaloriesUnit = table.Column<string>(type: "TEXT", nullable: true),
                    Fat = table.Column<double>(type: "REAL", nullable: false),
                    FatUnit = table.Column<string>(type: "TEXT", nullable: true),
                    FruitAndVegServings = table.Column<double>(type: "REAL", nullable: false),
                    NovaGroup = table.Column<double>(type: "REAL", nullable: false),
                    Protein = table.Column<double>(type: "REAL", nullable: false),
                    ProteinUnit = table.Column<string>(type: "TEXT", nullable: true),
                    Salt = table.Column<double>(type: "REAL", nullable: false),
                    SaltUnit = table.Column<string>(type: "TEXT", nullable: true),
                    SaturatedFat = table.Column<double>(type: "REAL", nullable: false),
                    SaturatedFatUnit = table.Column<string>(type: "TEXT", nullable: true),
                    Sodium = table.Column<double>(type: "REAL", nullable: false),
                    SodiumUnit = table.Column<string>(type: "TEXT", nullable: true),
                    Sugar = table.Column<double>(type: "REAL", nullable: false),
                    SugarUnit = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "FoodItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "AppUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "Id");
        }
    }
}
