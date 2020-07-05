using System.Collections.Generic;
using System.Linq;

namespace ItaBank.Mapping
{
    public static class AccountMapper
    {
        public static List<SDK.Models.Account> DomainToSDK(List<Domain.Models.Account> accounts)
        {
            return accounts.Select(a => DomainToSDK(a)).ToList();
        }

        public static List<Domain.Models.Account> SDKToDomain(List<SDK.Models.Account> accounts)
        {
            return accounts.Select(a => SDKToDomain(a)).ToList();
        }

        public static SDK.Models.Account DomainToSDK(Domain.Models.Account account)
        {
            var accountMapped = new SDK.Models.Account
            {
                Id = account.Id,
                Code = account.Code,
                Name = account.Name,
                Address = account.Address,
                Balance = account.Balance,
                Transactions = account.Transactions.Select(at => AccountTransactionMapper.DomainToSDK(at)).ToList()
            };

            return accountMapped;
        }

        public static Domain.Models.Account SDKToDomain(SDK.Models.Account account)
        {
            var accountMapped = new Domain.Models.Account
            {
                Id = account.Id,
                Code = account.Code,
                Name = account.Name,
                Address = account.Address,
                Balance = account.Balance,
                Transactions = account.Transactions.Select(at => AccountTransactionMapper.SDKToDomain(at)).ToList()
            };

            return accountMapped;
        }
    }
}
