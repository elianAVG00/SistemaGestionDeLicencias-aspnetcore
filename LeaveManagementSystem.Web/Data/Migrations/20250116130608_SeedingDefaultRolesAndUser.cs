using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a05d4dd3-e4d8-4537-a610-b021f06c36a3", null, "Administrator", "ADMINISTRATOR" },
                    { "aac4554b-9805-4238-b755-c368e9491287", null, "Employee", "EMPLOYEE" },
                    { "d0a2193d-109a-4de1-bcd2-9bfcb7a026bc", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8f26e98-1f94-4d22-a829-41d863b3412f", 0, "4f673d91-2f2d-4818-8f52-4b5bbc3d32b2", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECZuMlXwxycqogf6a5ff/ou/kn8Ukp9TjgLmIHdRog488+uZhx8DhCQ/SlK+wtID+A==", null, false, "bc8f98f8-73b1-43eb-b02b-5db33b25c64c", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a05d4dd3-e4d8-4537-a610-b021f06c36a3", "e8f26e98-1f94-4d22-a829-41d863b3412f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aac4554b-9805-4238-b755-c368e9491287");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0a2193d-109a-4de1-bcd2-9bfcb7a026bc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a05d4dd3-e4d8-4537-a610-b021f06c36a3", "e8f26e98-1f94-4d22-a829-41d863b3412f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a05d4dd3-e4d8-4537-a610-b021f06c36a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f26e98-1f94-4d22-a829-41d863b3412f");
        }
    }
}
