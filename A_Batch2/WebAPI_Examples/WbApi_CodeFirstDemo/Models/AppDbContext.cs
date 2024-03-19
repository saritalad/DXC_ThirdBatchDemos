﻿using Microsoft.EntityFrameworkCore;

namespace WbApi_CodeFirstDemo.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
       
        public DbSet<Category>Categories { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Employee>Employees { get; set; }
    }
}