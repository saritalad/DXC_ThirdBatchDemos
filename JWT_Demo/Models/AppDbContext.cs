using Microsoft.EntityFrameworkCore;

namespace JWT_Demo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employee{get;set;}
}
    
}