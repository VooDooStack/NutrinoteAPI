using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ProdcutsUidToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Products",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.CreateTable(
                name: "NutritionLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId1 = table.Column<string>(type: "text", nullable: true),
                    LogDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                        name: "FK_NutritionLog_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NutritionLog_AppUserId",
                table: "NutritionLog",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionLog_ProductId1",
                table: "NutritionLog",
                column: "ProductId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionLog");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Products",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: true),
                    CalciumIntake = table.Column<double>(type: "double precision", nullable: false),
                    CarbohydrateIntake = table.Column<double>(type: "double precision", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FatIntake = table.Column<double>(type: "double precision", nullable: false),
                    FiberIntake = table.Column<double>(type: "double precision", nullable: false),
                    IronIntake = table.Column<double>(type: "double precision", nullable: false),
                    ProteinIntake = table.Column<double>(type: "double precision", nullable: false),
                    SodiumIntake = table.Column<double>(type: "double precision", nullable: false),
                    SugarIntake = table.Column<double>(type: "double precision", nullable: false),
                    VitaminAIntake = table.Column<double>(type: "double precision", nullable: false),
                    VitaminCIntake = table.Column<double>(type: "double precision", nullable: false),
                    WaterIntake = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nutrition_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nutrition_AppUserId",
                table: "Nutrition",
                column: "AppUserId");
        }
    }
}
