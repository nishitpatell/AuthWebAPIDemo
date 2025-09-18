using AuthWebAPIDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthWebAPIDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<User> WebAPIUsers { get; set; }
    }
}
