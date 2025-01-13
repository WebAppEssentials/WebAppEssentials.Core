using System.ComponentModel.DataAnnotations;

namespace WebAppEssentials.Models.Authentication;

public class UserRegisterDto
{
    [Required] [EmailAddress] public required string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
        MinimumLength = 6)]
    public required string Password { get; set; }

    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    [DataType(DataType.Password)]
    public required string ConfirmPassword { get; set; }

    [StringLength(255)]
    public string? FirstName { get; set; }
    [StringLength(255)]
    public string? LastName { get; set; }
}