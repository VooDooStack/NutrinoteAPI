using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class AppUser
{
    public string Id { get; set; }
    public string Email { get; init; }
    public string Username { get; init; }
    public bool EmailVerified { get; init; }
    public  double Weight { get; set; }
    public  double Height { get; set; }
    public  double Age { get; set; }
    public  double ActivityLevel { get; set; }
    public  double Bmr { get; set; }
    public  double Tdee { get; set; }
public  String Gender { get; set; }
    [NotMapped] 
    public string Token { get; set; }
    public IEnumerable<NutritionLog> NutritionLogs { get; set; }
}