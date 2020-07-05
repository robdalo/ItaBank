using ItaBank.Domain.Models;
using System.Collections.Generic;

namespace ItaBank.Core.DataAccess.Repos.Interfaces
{
    public interface IAccountRepo
    {
        List<Account> Get();
    }
}
