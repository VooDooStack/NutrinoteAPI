namespace API.DTOs;

public class RegisterDto
{
    public string DisplayName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? ImageUrl { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public double ActivityLevel { get; set; }
    public String Gender { get; set; }
}