using Microsoft.EntityFrameworkCore;
namespace RazorEF_CodeFirstDemo.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options) { }
       

        public DbSet<Department>Departments { get; set; }
        public  DbSet<Employee>Employees { get; set; }
    }
}
