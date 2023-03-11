using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class nutrition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<Guid>(
                name: "NutrientsId",
                table: "Products",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Carbohydrates = table.Column<double>(type: "double precision", nullable: false),
                    Carbohydrates100G = table.Column<double>(type: "double precision", nullable: false),
                    CarbohydratesServing = table.Column<long>(type: "bigint", nullable: false),
                    CarbohydratesUnit = table.Column<string>(type: "text", nullable: true),
                    CarbohydratesValue = table.Column<double>(type: "double precision", nullable: false),
                    CarbonFootprintFromKnownIngredients100G = table.Column<double>(type: "double precision", nullable: false),
                    CarbonFootprintFromKnownIngredientsProduct = table.Column<long>(type: "bigint", nullable: false),
                    CarbonFootprintFromKnownIngredientsServing = table.Column<double>(type: "double precision", nullable: false),
                    Energy = table.Column<long>(type: "bigint", nullable: false),
                    EnergyKcal = table.Column<long>(type: "bigint", nullable: false),
                    EnergyKcal100G = table.Column<long>(type: "bigint", nullable: false),
                    EnergyKcalServing = table.Column<long>(type: "bigint", nullable: false),
                    EnergyKcalUnit = table.Column<string>(type: "text", nullable: true),
                    EnergyKcalValue = table.Column<long>(type: "bigint", nullable: false),
                    EnergyKcalValueComputed = table.Column<double>(type: "double precision", nullable: false),
                    EnergyKj = table.Column<long>(type: "bigint", nullable: false),
                    EnergyKj100G = table.Column<long>(type: "bigint", nullable: false),
                    EnergyKjServing = table.Column<long>(type: "bigint", nullable: false),
                    EnergyKjUnit = table.Column<string>(type: "text", nullable: true),
                    EnergyKjValue = table.Column<long>(type: "bigint", nullable: false),
                    EnergyKjValueComputed = table.Column<double>(type: "double precision", nullable: false),
                    Energy100G = table.Column<long>(type: "bigint", nullable: false),
                    EnergyServing = table.Column<long>(type: "bigint", nullable: false),
                    EnergyUnit = table.Column<string>(type: "text", nullable: true),
                    EnergyValue = table.Column<long>(type: "bigint", nullable: false),
                    Fat = table.Column<double>(type: "double precision", nullable: false),
                    Fat100G = table.Column<double>(type: "double precision", nullable: false),
                    FatServing = table.Column<double>(type: "double precision", nullable: false),
                    FatUnit = table.Column<string>(type: "text", nullable: true),
                    FatValue = table.Column<double>(type: "double precision", nullable: false),
                    Fiber = table.Column<double>(type: "double precision", nullable: false),
                    Fiber100G = table.Column<double>(type: "double precision", nullable: false),
                    FiberServing = table.Column<double>(type: "double precision", nullable: false),
                    FiberUnit = table.Column<string>(type: "text", nullable: true),
                    FiberValue = table.Column<double>(type: "double precision", nullable: false),
                    FruitsVegetablesNutsEstimateFromIngredients100G = table.Column<long>(type: "bigint", nullable: false),
                    FruitsVegetablesNutsEstimateFromIngredientsServing = table.Column<long>(type: "bigint", nullable: false),
                    NovaGroup = table.Column<long>(type: "bigint", nullable: false),
                    NovaGroup100G = table.Column<long>(type: "bigint", nullable: false),
                    NovaGroupServing = table.Column<long>(type: "bigint", nullable: false),
                    NutritionScoreFr = table.Column<long>(type: "bigint", nullable: false),
                    NutritionScoreFr100G = table.Column<long>(type: "bigint", nullable: false),
                    Proteins = table.Column<double>(type: "double precision", nullable: false),
                    Proteins100G = table.Column<double>(type: "double precision", nullable: false),
                    ProteinsServing = table.Column<double>(type: "double precision", nullable: false),
                    ProteinsUnit = table.Column<string>(type: "text", nullable: true),
                    ProteinsValue = table.Column<double>(type: "double precision", nullable: false),
                    Salt = table.Column<double>(type: "double precision", nullable: false),
                    Salt100G = table.Column<double>(type: "double precision", nullable: false),
                    SaltServing = table.Column<double>(type: "double precision", nullable: false),
                    SaltUnit = table.Column<string>(type: "text", nullable: true),
                    SaltValue = table.Column<double>(type: "double precision", nullable: false),
                    SaturatedFat = table.Column<long>(type: "bigint", nullable: false),
                    SaturatedFat100G = table.Column<long>(type: "bigint", nullable: false),
                    SaturatedFatServing = table.Column<double>(type: "double precision", nullable: false),
                    SaturatedFatUnit = table.Column<string>(type: "text", nullable: true),
                    SaturatedFatValue = table.Column<long>(type: "bigint", nullable: false),
                    Sodium = table.Column<double>(type: "double precision", nullable: false),
                    Sodium100G = table.Column<double>(type: "double precision", nullable: false),
                    SodiumServing = table.Column<double>(type: "double precision", nullable: false),
                    SodiumUnit = table.Column<string>(type: "text", nullable: true),
                    SodiumValue = table.Column<double>(type: "double precision", nullable: false),
                    Sugars = table.Column<double>(type: "double precision", nullable: false),
                    Sugars100G = table.Column<double>(type: "double precision", nullable: false),
                    SugarsServing = table.Column<double>(type: "double precision", nullable: false),
                    SugarsUnit = table.Column<string>(type: "text", nullable: true),
                    SugarsValue = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_NutrientsId",
                table: "Products",
                column: "NutrientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Nutrients_NutrientsId",
                table: "Products",
                column: "NutrientsId",
                principalTable: "Nutrients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Nutrients_NutrientsId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Nutrients");

            migrationBuilder.DropIndex(
                name: "IX_Products_NutrientsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NutrientsId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Barcode",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
