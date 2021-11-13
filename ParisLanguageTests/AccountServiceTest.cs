using FluentAssertions;
using NUnit.Framework;
using ParisLanguageApplication.DTOs.Account;
using ParisLanguageInfrastructure.Services;
using System;

namespace ParisLanguageTests
{
    [TestFixture]
    public class AccountServiceTest
    {
        private AccountService _accountService;
        private RegisterRequest _registerRequest;

        [SetUp]
        public void Setup()
        {
            _accountService = new AccountService();
            _registerRequest = new RegisterRequest();
        }

        [Test]
        public void RegisterAsync_ShouldModelNull_GivenThrows()
        {
            Assert.Throws<ArgumentNullException>(() => _accountService.RegisterAsync(_registerRequest, null));
        }

        [Test]
        public void RegisterAsync_ShouldUserValide_GivenUserName()
        {
            var userCompare = "Xuxa";
            _registerRequest = new RegisterRequest
            {
                UserName = "xuxando",
                FirstName = "Xuxa",
                LastName = "Xaxa",
                Email = "xuxandoMuito@gmail.com",
                PhoneNumber = "11000000000",
                CpfNumber = "000.000.00-00",
                Password = "vamos_ver_se_deu_merda_kkkkk",
                ConfirmPassword = "vamos_ver_se_deu_merda_kkkkk"
            };

            _accountService.RegisterAsync(_registerRequest, null).Data.Should().BeEquivalentTo(userCompare);
        }
    }
}