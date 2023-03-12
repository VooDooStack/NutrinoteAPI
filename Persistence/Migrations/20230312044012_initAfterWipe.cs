using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initAfterWipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Username = table.Column<string>(type: "text", nullable: true),
                    EmailVerified = table.Column<bool>(type: "boolean", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    Height = table.Column<double>(type: "double precision", nullable: false),
                    Age = table.Column<double>(type: "double precision", nullable: false),
                    ActivityLevel = table.Column<double>(type: "double precision", nullable: false),
                    Bmr = table.Column<double>(type: "double precision", nullable: false),
                    Tdee = table.Column<double>(type: "double precision", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Carbohydrates = table.Column<double>(type: "double precision", nullable: true),
                    Carbohydrates100G = table.Column<double>(type: "double precision", nullable: true),
                    CarbohydratesServing = table.Column<double>(type: "double precision", nullable: true),
                    CarbohydratesUnit = table.Column<string>(type: "text", nullable: true),
                    CarbohydratesValue = table.Column<double>(type: "double precision", nullable: true),
                    CarbonFootprintFromKnownIngredients100G = table.Column<double>(type: "double precision", nullable: true),
                    CarbonFootprintFromKnownIngredientsProduct = table.Column<double>(type: "double precision", nullable: true),
                    CarbonFootprintFromKnownIngredientsServing = table.Column<double>(type: "double precision", nullable: true),
                    Energy = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKcal = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKcal100G = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKcalServing = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKcalUnit = table.Column<string>(type: "text", nullable: true),
                    EnergyKcalValue = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKcalValueComputed = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKj = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKj100G = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKjServing = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKjUnit = table.Column<string>(type: "text", nullable: true),
                    EnergyKjValue = table.Column<double>(type: "double precision", nullable: true),
                    EnergyKjValueComputed = table.Column<double>(type: "double precision", nullable: true),
                    Energy100G = table.Column<double>(type: "double precision", nullable: true),
                    EnergyServing = table.Column<double>(type: "double precision", nullable: true),
                    EnergyUnit = table.Column<string>(type: "text", nullable: true),
                    EnergyValue = table.Column<double>(type: "double precision", nullable: true),
                    Fat = table.Column<double>(type: "double precision", nullable: true),
                    Fat100G = table.Column<double>(type: "double precision", nullable: true),
                    FatServing = table.Column<double>(type: "double precision", nullable: true),
                    FatUnit = table.Column<string>(type: "text", nullable: true),
                    FatValue = table.Column<double>(type: "double precision", nullable: true),
                    Fiber = table.Column<double>(type: "double precision", nullable: true),
                    Fiber100G = table.Column<double>(type: "double precision", nullable: true),
                    FiberServing = table.Column<double>(type: "double precision", nullable: true),
                    FiberUnit = table.Column<string>(type: "text", nullable: true),
                    FiberValue = table.Column<double>(type: "double precision", nullable: true),
                    FruitsVegetablesNutsEstimateFromIngredients100G = table.Column<double>(type: "double precision", nullable: true),
                    FruitsVegetablesNutsEstimateFromIngredientsServing = table.Column<double>(type: "double precision", nullable: true),
                    NovaGroup = table.Column<double>(type: "double precision", nullable: true),
                    NovaGroup100G = table.Column<double>(type: "double precision", nullable: true),
                    NovaGroupServing = table.Column<double>(type: "double precision", nullable: true),
                    NutritionScoreFr = table.Column<double>(type: "double precision", nullable: true),
                    NutritionScoreFr100G = table.Column<double>(type: "double precision", nullable: true),
                    Proteins = table.Column<double>(type: "double precision", nullable: true),
                    Proteins100G = table.Column<double>(type: "double precision", nullable: true),
                    ProteinsServing = table.Column<double>(type: "double precision", nullable: true),
                    ProteinsUnit = table.Column<string>(type: "text", nullable: true),
                    ProteinsValue = table.Column<double>(type: "double precision", nullable: true),
                    Salt = table.Column<double>(type: "double precision", nullable: true),
                    Salt100G = table.Column<double>(type: "double precision", nullable: true),
                    SaltServing = table.Column<double>(type: "double precision", nullable: true),
                    SaltUnit = table.Column<string>(type: "text", nullable: true),
                    SaltValue = table.Column<double>(type: "double precision", nullable: true),
                    SaturatedFat = table.Column<double>(type: "double precision", nullable: true),
                    SaturatedFat100G = table.Column<double>(type: "double precision", nullable: true),
                    SaturatedFatServing = table.Column<double>(type: "double precision", nullable: true),
                    SaturatedFatUnit = table.Column<string>(type: "text", nullable: true),
                    SaturatedFatValue = table.Column<double>(type: "double precision", nullable: true),
                    Sodium = table.Column<double>(type: "double precision", nullable: true),
                    Sodium100G = table.Column<double>(type: "double precision", nullable: true),
                    SodiumServing = table.Column<double>(type: "double precision", nullable: true),
                    SodiumUnit = table.Column<string>(type: "text", nullable: true),
                    SodiumValue = table.Column<double>(type: "double precision", nullable: true),
                    Sugars = table.Column<double>(type: "double precision", nullable: true),
                    Sugars100G = table.Column<double>(type: "double precision", nullable: true),
                    SugarsServing = table.Column<double>(type: "double precision", nullable: true),
                    SugarsUnit = table.Column<string>(type: "text", nullable: true),
                    SugarsValue = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "text", nullable: true),
                    Barcode = table.Column<string>(type: "text", nullable: true),
                    NutrientsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Nutrients_NutrientsId",
                        column: x => x.NutrientsId,
                        principalTable: "Nutrients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NutritionLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<string>(type: "text", nullable: true),
                    Servings = table.Column<double>(type: "double precision", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionLog_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NutritionLog_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NutritionLog_AppUserId",
                table: "NutritionLog",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionLog_ProductId",
                table: "NutritionLog",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_NutrientsId",
                table: "Products",
                column: "NutrientsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionLog");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Nutrients");
        }
    }
}
