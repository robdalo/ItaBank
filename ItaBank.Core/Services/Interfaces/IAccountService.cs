using ItaBank.Domain.Models;
using System.Collections.Generic;

namespace ItaBank.Core.Services.Interfaces
{
    public interface IAccountService
    {
        List<Account> Get();
    }
}
