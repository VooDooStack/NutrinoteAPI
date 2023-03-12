using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UserAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ActivityLevel",
                table: "AppUsers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Age",
                table: "AppUsers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Bmr",
                table: "AppUsers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AppUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "AppUsers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Tdee",
                table: "AppUsers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "AppUsers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityLevel",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Bmr",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Tdee",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "AppUsers");
        }
    }
}
