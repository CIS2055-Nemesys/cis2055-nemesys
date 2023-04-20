using Microsoft.EntityFrameworkCore;

namespace nemesis.Models.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }

        public DbSet<Investigation> Investigations { get; set; }

        public DbSet<Category> Categories { get; set; }



    }
}
