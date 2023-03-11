using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class AppUser
{
    public string Id { get; set; }
    public string Email { get; init; }
    public string Username { get; init; }

    public bool EmailVerified { get; init; }

    // ignore this property for migrations from entity framework
    [NotMapped] public string Token { get; init; }

    public IEnumerable<NutritionLog> NutritionLogs { get; set; }
}