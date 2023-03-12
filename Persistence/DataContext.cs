using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<NutritionLog> NutritionLog { get; set; }

    public DbSet<Nutrients> Nutrients { get; set; }
    public DbSet<Product> Products { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<NutritionLog>()
            .Property(ud => ud.UpdatedAt).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
        builder.Entity<NutritionLog>()
            .Property(cd => cd.CreatedAt).ValueGeneratedOnAdd(); 
    }
    
}