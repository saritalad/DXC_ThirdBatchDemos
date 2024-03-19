using Microsoft.EntityFrameworkCore;
using webAPI6.ViewModel;

namespace webAPI6.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }

       public DbSet<Product> Products { get; set; }
        public DbSet<Category>Categories { get; set; }
        // this is a viewModel , it is not a table 
        public DbSet<CategoryProducts> CategorywiseProducts { get; set; }
    }
}
