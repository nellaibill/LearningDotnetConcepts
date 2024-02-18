using Auth_DB_EFCore_Reg_Login.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth_DB_EFCore_Reg_Login.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => { entity.HasIndex(u => u.Email).IsUnique(); });
        }
    }
}
