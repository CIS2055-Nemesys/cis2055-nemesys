using Microsoft.EntityFrameworkCore;

namespace nemesis.Models.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }


        public DbSet<User> users { get; set; }
        public DbSet<Report> reports { get; set; }

        public DbSet<Investigation> investigations { get; set; }

        public DbSet<Category> categories { get; set; }



    }
}
