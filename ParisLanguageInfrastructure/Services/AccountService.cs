using ParisLanguageApplication.DTOs.Account;
using ParisLanguageApplication.Exceptions;
using ParisLanguageApplication.Interfaces;
using ParisLanguageApplication.Wrappers;
using ParisLanguageInfrastructure.Models;
using System;

namespace ParisLanguageInfrastructure.Services
{
    public class AccountService : IAccountService
    {
        public Response<string> RegisterAsync(RegisterRequest request, string origin)
        {
            if (string.IsNullOrEmpty(request.UserName) && string.IsNullOrEmpty(request.Email))
            {
                throw new ArgumentNullException("É necessario informar tudo daados.");
            }

            var userWithSameUserName = false;
            if (userWithSameUserName == true)
            {
                throw new ArgumentNullException("Usuario já tem cadastroo");
            }
            var user = new ApplicationUser
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName
            };

            if (string.IsNullOrEmpty(user.Email))
            {
                return null;
            }
            return new Response<string>(user.FirstName, null);
        }
    }
}