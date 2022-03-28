
using Microsoft.EntityFrameworkCore;
using MyInAndOut.Models;

namespace MyInAndOut.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
