using System.ComponentModel.DataAnnotations;

namespace ParisLanguageApplication.DTOs.Account
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}