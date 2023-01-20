using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) {}
        
         public DbSet<AppUser> AppUsers { get; set; }
         public DbSet<FoodItem> FoodItems { get; set; }
        
    }
}