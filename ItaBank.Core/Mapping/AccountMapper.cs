using System.Linq;

namespace ItaBank.Core.Mapping
{
    public static class AccountMapper
    {
        public static SDK.Models.Account Map(Domain.Models.Account account)
        {
            var accountMapped = new SDK.Models.Account
            {
                Id = account.Id,
                Code = account.Code,
                Name = account.Name,
                Address = account.Address,
                Balance = account.Balance,
                Transactions = account.Transactions.Select(at => AccountTransactionMapper.Map(at)).ToList()
            };

            return accountMapped;
        }
    }
}
