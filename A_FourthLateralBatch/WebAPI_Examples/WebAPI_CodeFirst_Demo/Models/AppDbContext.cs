using Microsoft.EntityFrameworkCore;

namespace WebAPI_CodeFirst_Demo.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
      

        public DbSet<Product>Products { get; set; }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
