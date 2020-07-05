using ItaBank.Core.DataAccess.Repos.Interfaces;
using ItaBank.Core.Services.Interfaces;
using ItaBank.Domain.Models;
using System.Collections.Generic;

namespace ItaBank.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepo _accountRepo;

        public AccountService(IAccountRepo accountRepo)
        {
            _accountRepo = accountRepo;
        }

        public List<Account> Get()
        {
            return _accountRepo.Get();
        }
    }
}
