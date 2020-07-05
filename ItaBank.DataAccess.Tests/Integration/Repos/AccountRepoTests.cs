using ItaBank.DataAccess.Repos;
using ItaBank.DataAccess.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Linq;

namespace ItaBank.DataAccess.Tests.Integration.Repos
{
    public class AccountRepoTests
    {
        private readonly ItaBankContext _context;

        private readonly IAccountRepo _accountRepo;
        private readonly IConfiguration _configuration;

        public AccountRepoTests()
        {
            _configuration = new ConfigurationBuilder()
                .AddUserSecrets<AccountRepoTests>()
                .Build();

            var connectionString = _configuration["ItaBankConnectionString"];

            var builder = new DbContextOptionsBuilder<ItaBankContext>();
            builder.UseSqlServer(connectionString);

            _context = new ItaBankContext(builder.Options);
            _accountRepo = new AccountRepo(_context);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_ReturnsListOfAccounts()
        {
            var accounts = _accountRepo.Get();
            Assert.True(accounts.Any());
        }
    }
}
