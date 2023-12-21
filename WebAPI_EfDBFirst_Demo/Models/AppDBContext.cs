using Microsoft.EntityFrameworkCore;

namespace WebAPI_EfDBFirst_Demo.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options) { }
        

        public DbSet<Product>Products { get; set; }
    }
}
