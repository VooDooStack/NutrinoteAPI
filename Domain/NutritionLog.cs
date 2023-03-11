namespace Domain;

public class NutritionLog
{
    public Guid Id { get; set; }
    public string AppUserId { get; set; } // foreign key to AppUser
    public AppUser AppUser { get; set; }
    public string ProductId { get; set; } // foreign key to Product
    public Product Product { get; set; }
    public DateTime LogDate { get; set; }
}