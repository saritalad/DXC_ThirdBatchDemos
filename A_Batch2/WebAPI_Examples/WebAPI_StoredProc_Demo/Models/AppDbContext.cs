using Microsoft.EntityFrameworkCore;

namespace WebAPI_StoredProc_Demo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
      
        public DbSet<Product>Products { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<CatNProduct>CatNProducts { get; set; }
    }
}
