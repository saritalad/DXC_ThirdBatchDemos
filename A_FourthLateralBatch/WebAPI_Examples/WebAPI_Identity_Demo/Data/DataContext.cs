using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_Identity_Demo.Data
{
    
        public class DataContext : IdentityDbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        }
    }
