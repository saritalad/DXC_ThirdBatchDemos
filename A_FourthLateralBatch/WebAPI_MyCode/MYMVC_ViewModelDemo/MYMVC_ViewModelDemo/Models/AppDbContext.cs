using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MYMVC_ViewModelDemo.Models;

namespace MYMVC_ViewModelDemo.Models
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryProductViewModel> Catwiseproducts { get; set; }
        public DbSet<MYMVC_ViewModelDemo.Models.StudentDetailsViewModel> StudentDetailsViewModel { get; set; }
    }
}
