using Microsoft.EntityFrameworkCore;
using RazCRUD.Model;

namespace RazCRUD.Data
{
    // like a data layer that will connect our application with the database
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //prop name here will be actual table name
        public DbSet<Category> Category { get; set; }



    }
}
