using ItaBank.DataAccess.Repos.Interfaces;
using ItaBank.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ItaBank.DataAccess.Repos
{
    public class AccountRepo : IAccountRepo
    {
        private readonly ItaBankContext _context;

        public AccountRepo(ItaBankContext context)
        {
            _context = context;
        }

        public List<Account> Get()
        {
            return _context.Accounts.Include(a => a.Transactions).ToList();
        }
    }
}
