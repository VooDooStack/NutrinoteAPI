using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PostgressInitial : Migration
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
                    EmailVerified = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "text", nullable: true),
                    Barcode = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: true),
                    ProteinIntake = table.Column<double>(type: "double precision", nullable: false),
                    CarbohydrateIntake = table.Column<double>(type: "double precision", nullable: false),
                    FatIntake = table.Column<double>(type: "double precision", nullable: false),
                    FiberIntake = table.Column<double>(type: "double precision", nullable: false),
                    SugarIntake = table.Column<double>(type: "double precision", nullable: false),
                    CalciumIntake = table.Column<double>(type: "double precision", nullable: false),
                    IronIntake = table.Column<double>(type: "double precision", nullable: false),
                    SodiumIntake = table.Column<double>(type: "double precision", nullable: false),
                    VitaminAIntake = table.Column<double>(type: "double precision", nullable: false),
                    VitaminCIntake = table.Column<double>(type: "double precision", nullable: false),
                    WaterIntake = table.Column<double>(type: "double precision", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                column: "AppUserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
