
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_Identity_Patrik.Data
{
    public class DataContext:IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
    }
}
