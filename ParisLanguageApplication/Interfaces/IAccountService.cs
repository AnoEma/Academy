using ParisLanguageApplication.DTOs.Account;
using ParisLanguageApplication.Wrappers;

namespace ParisLanguageApplication.Interfaces
{
    public interface IAccountService
    {
        Response<string> RegisterAsync(RegisterRequest request, string origin);
    }
}