using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<NutritionLog> NutritionLog { get; set; }

    public DbSet<Nutrients> Nutrients { get; set; }

    //create db sets for every class inside product.cs
    public DbSet<Product> Products { get; set; }
}