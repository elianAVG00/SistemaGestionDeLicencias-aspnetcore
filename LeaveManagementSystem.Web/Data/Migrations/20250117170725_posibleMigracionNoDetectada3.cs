using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class posibleMigracionNoDetectada3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f26e98-1f94-4d22-a829-41d863b3412f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8395d7a4-168b-4121-8e8e-6c38371696f6", "AQAAAAIAAYagAAAAENrfUY+FaENMc+xM3OIOiiJAlYR8OcQv5kd1WpGwybl1b0222rcg2EDqBL7/OQnFvQ==", "44984c33-6c1e-46aa-b819-41afd0eb3839" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f26e98-1f94-4d22-a829-41d863b3412f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "089a6263-b012-469e-a9bc-4760abf23482", "AQAAAAIAAYagAAAAEFj6zdxciHol+PjouNTd4TT4jV4KTl23EtHy7VnzoyAHVY+Jskmy9pPh1+fXDtg5HA==", "3b10e808-9f61-4ae7-bbde-ed4a61f63479" });
        }
    }
}
