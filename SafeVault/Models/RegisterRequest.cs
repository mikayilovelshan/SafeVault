using System.ComponentModel.DataAnnotations;

namespace SafeVault.Models
{
    public class RegisterRequest
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z0-9_]+$")]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(254)]
        public string Email { get; set; } = string.Empty;
    }
}
