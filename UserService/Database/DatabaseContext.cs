using Microsoft.EntityFrameworkCore;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9U8FRGU\SQLEXPRESS;Initial Catalog=UserMicroService;" +
                "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
