using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class posibleMigracionNoDetectada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f26e98-1f94-4d22-a829-41d863b3412f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6fe289b-6a5c-4017-9fc8-2619ea8fcb70", "AQAAAAIAAYagAAAAEFgBsvE4z0xu5gvGaBp93hfhXPgeu+fCdnlmbh/IfZPktTEj/Mu4Ffc+HZJtpYnTpA==", "d516e3a4-5142-4d88-97c6-32fde2685d1a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f26e98-1f94-4d22-a829-41d863b3412f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c2c3b4d-d7bb-41e6-97fd-3fc79b17e19b", "AQAAAAIAAYagAAAAEJD7RZvTHrLA+k2Rr7098/Zsxe6Eu9fGY3k9uhKyb0EMnVoo86ka5yd6N+XhxBh31Q==", "245c2ee1-505f-4a14-850f-8d2e667eb3fc" });
        }
    }
}
