using Microsoft.EntityFrameworkCore;
using MyRC1.Model;

namespace MyRC1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Category> Category { get; set; }
    }
}
