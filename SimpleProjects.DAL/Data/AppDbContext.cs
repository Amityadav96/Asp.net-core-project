using Microsoft.EntityFrameworkCore;
using SimpleProjects.Models;

namespace SimpleProjects.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Category>  Categories { get; set; }
    }
}
