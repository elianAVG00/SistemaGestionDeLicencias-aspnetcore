using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f26e98-1f94-4d22-a829-41d863b3412f",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c2c3b4d-d7bb-41e6-97fd-3fc79b17e19b", new DateOnly(1950, 12, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEJD7RZvTHrLA+k2Rr7098/Zsxe6Eu9fGY3k9uhKyb0EMnVoo86ka5yd6N+XhxBh31Q==", "245c2ee1-505f-4a14-850f-8d2e667eb3fc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f26e98-1f94-4d22-a829-41d863b3412f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f673d91-2f2d-4818-8f52-4b5bbc3d32b2", "AQAAAAIAAYagAAAAECZuMlXwxycqogf6a5ff/ou/kn8Ukp9TjgLmIHdRog488+uZhx8DhCQ/SlK+wtID+A==", "bc8f98f8-73b1-43eb-b02b-5db33b25c64c" });
        }
    }
}
