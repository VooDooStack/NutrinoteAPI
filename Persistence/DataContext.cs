using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) {}
        
         public DbSet<AppUser> AppUser { get; set; }
         public DbSet<Product> Products { get; set; }
        
    }
}