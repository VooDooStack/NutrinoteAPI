using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain;

public class NutritionLog
{
    public Guid Id { get; set; }
    [JsonIgnore]
    public string AppUserId { get; set; } // foreign key to AppUser
    [JsonIgnore]
    public AppUser AppUser { get; set; }
    public string ProductId { get; set; } // foreign key to Product
    public Product Product { get; set; }
    public double Servings { get; set; } 
    public DateTime CreatedAt { get; set; }  
    public DateTime UpdatedAt { get; set; } // soft update
    public DateTime? DeletedAt { get; set; } // soft delete
}