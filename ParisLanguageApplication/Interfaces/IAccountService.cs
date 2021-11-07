using ParisLanguageApplication.DTOs.Account;
using ParisLanguageApplication.Wrappers;
using System.Threading.Tasks;

namespace ParisLanguageApplication.Interfaces
{
    public interface IAccountService
    {
        Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
    }
}