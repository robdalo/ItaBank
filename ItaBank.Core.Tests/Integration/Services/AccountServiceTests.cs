using ItaBank.Core.DataAccess;
using ItaBank.Core.DataAccess.Repos;
using ItaBank.Core.Services;
using ItaBank.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Linq;

namespace ItaBank.Core.Tests.Integration.Services
{
    public class AccountServiceTests
    {
        private readonly IAccountService _accountService;

        public AccountServiceTests()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<AccountServiceTests>()
                .Build();

            var connectionString = configuration["ItaBankConnectionString"];

            var builder = new DbContextOptionsBuilder<ItaBankContext>();
            builder.UseSqlServer(connectionString);

            var context = new ItaBankContext(builder.Options);
            var accountRepo = new AccountRepo(context);

            _accountService = new AccountService(accountRepo);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_ReturnsListOfAccounts()
        {
            var accounts = _accountService.Get();
            Assert.True(accounts.Any());
        }
    }
}
