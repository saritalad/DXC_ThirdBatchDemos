using Microsoft.EntityFrameworkCore;

namespace WebApi_6_demo.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
        
     public   DbSet<Product>products { get; set; }
    }
}
