using ParisLanguageApplication.DTOs.Account;
using ParisLanguageApplication.Exceptions;
using ParisLanguageApplication.Interfaces;
using ParisLanguageApplication.Wrappers;
using ParisLanguageInfrastructure.Models;
using System.Threading.Tasks;

namespace ParisLanguageInfrastructure.Services
{
    public class AccountService : IAccountService
    {
        public Task<Response<string>> RegisterAsync(RegisterRequest request, string origin)
        {
            var userWithSameUserName = "xuxa";
            if (userWithSameUserName != null)
            {
                throw new ApiException($"Username '{request.UserName}' is already taken.");
            }
            var user = new ApplicationUser
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName
            };

            return null;
        }
    }
}