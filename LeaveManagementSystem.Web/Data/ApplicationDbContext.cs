using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "aac4554b-9805-4238-b755-c368e9491287", Name = "Employee", NormalizedName = "EMPLOYEE"},
                new IdentityRole() { Id = "d0a2193d-109a-4de1-bcd2-9bfcb7a026bc", Name = "Supervisor", NormalizedName = "SUPERVISOR" },
                new IdentityRole() { Id = "a05d4dd3-e4d8-4537-a610-b021f06c36a3", Name = "Administrator", NormalizedName = "ADMINISTRATOR" }
            );

            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser() { Id = "e8f26e98-1f94-4d22-a829-41d863b3412f", Email = "admin@localhost.com", NormalizedEmail = "ADMIN@LOCALHOST.COM", 
                    UserName = "admin@localhost.com", NormalizedUserName = "ADMIN@LOCALHOST.COM", PasswordHash = hasher.HashPassword(null, "Password1"), EmailConfirmed = true,
                    FirstName = "Default", LastName = "Admin", DateOfBirth = new DateOnly(1950,12,1)}
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "a05d4dd3-e4d8-4537-a610-b021f06c36a3", UserId = "e8f26e98-1f94-4d22-a829-41d863b3412f"
                }
            );
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
