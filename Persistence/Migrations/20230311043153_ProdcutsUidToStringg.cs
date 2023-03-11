using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ProdcutsUidToStringg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionLog_Products_ProductId1",
                table: "NutritionLog");

            migrationBuilder.DropIndex(
                name: "IX_NutritionLog_ProductId1",
                table: "NutritionLog");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "NutritionLog");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "NutritionLog",
                type: "text",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionLog_ProductId",
                table: "NutritionLog",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionLog_Products_ProductId",
                table: "NutritionLog",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionLog_Products_ProductId",
                table: "NutritionLog");

            migrationBuilder.DropIndex(
                name: "IX_NutritionLog_ProductId",
                table: "NutritionLog");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "NutritionLog",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductId1",
                table: "NutritionLog",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionLog_ProductId1",
                table: "NutritionLog",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionLog_Products_ProductId1",
                table: "NutritionLog",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
