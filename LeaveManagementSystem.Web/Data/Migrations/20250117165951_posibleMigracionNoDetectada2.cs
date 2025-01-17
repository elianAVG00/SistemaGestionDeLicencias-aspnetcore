using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class posibleMigracionNoDetectada2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f26e98-1f94-4d22-a829-41d863b3412f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "089a6263-b012-469e-a9bc-4760abf23482", "AQAAAAIAAYagAAAAEFj6zdxciHol+PjouNTd4TT4jV4KTl23EtHy7VnzoyAHVY+Jskmy9pPh1+fXDtg5HA==", "3b10e808-9f61-4ae7-bbde-ed4a61f63479" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f26e98-1f94-4d22-a829-41d863b3412f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6fe289b-6a5c-4017-9fc8-2619ea8fcb70", "AQAAAAIAAYagAAAAEFgBsvE4z0xu5gvGaBp93hfhXPgeu+fCdnlmbh/IfZPktTEj/Mu4Ffc+HZJtpYnTpA==", "d516e3a4-5142-4d88-97c6-32fde2685d1a" });
        }
    }
}
