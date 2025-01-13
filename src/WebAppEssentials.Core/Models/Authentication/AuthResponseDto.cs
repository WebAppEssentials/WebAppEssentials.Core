namespace WebAppEssentials.Models.Authentication;

public class AuthResponseDto
{
    public required string UserId { get; set; }
    public required string Token { get; set; }
    public required string Email { get; set; }
}