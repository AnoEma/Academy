using Microsoft.AspNetCore.Identity;

namespace ParisLanguageInfrastructure.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}