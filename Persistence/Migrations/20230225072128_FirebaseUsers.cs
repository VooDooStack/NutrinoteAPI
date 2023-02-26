using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FirebaseUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "AppUser");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AppUser",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "AppUser",
                newName: "EmailVerified");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "AppUser",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "EmailVerified",
                table: "AppUser",
                newName: "TwoFactorEnabled");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "AppUser",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppUser",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AppUser",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AppUser",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AppUser",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AppUser",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AppUser",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "AppUser",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "AppUser",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "AppUser",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AppUser",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AppUser",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "AppUser",
                type: "text",
                nullable: true);
        }
    }
}
