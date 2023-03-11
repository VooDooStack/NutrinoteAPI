using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AppUserNutritionRelationAlter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Nutrition_AppUserId",
                table: "Nutrition");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrition_AppUserId",
                table: "Nutrition",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Nutrition_AppUserId",
                table: "Nutrition");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrition_AppUserId",
                table: "Nutrition",
                column: "AppUserId",
                unique: true);
        }
    }
}
