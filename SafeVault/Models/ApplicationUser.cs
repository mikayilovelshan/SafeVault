using Microsoft.AspNetCore.Identity;

namespace SafeVault.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
