


using Microsoft.EntityFrameworkCore;
using WebAPI_StoredProc_Demo.Models;

public class AppDBContext:DbContext
{

    public AppDBContext(DbContextOptions<AppDBContext>options):base(options)
    {
        
    }
      public DbSet<Product>products { get; set; }
      public  DbSet<Category>categories { get; set; }
      public DbSet<ProductDetail> productsDetails { get; set;}

}