using System.Collections.Generic;
using System.Linq;

namespace ItaBank.Mapping
{
    public static class AccountTransactionMapper
    {
        public static List<SDK.Models.AccountTransaction> DomainToSDK(List<Domain.Models.AccountTransaction> accountTransactions)
        {
            return accountTransactions.Select(a => DomainToSDK(a)).ToList();
        }

        public static List<Domain.Models.AccountTransaction> SDKToDomain(List<SDK.Models.AccountTransaction> accountTransactions)
        {
            return accountTransactions.Select(a => SDKToDomain(a)).ToList();
        }

        public static SDK.Models.AccountTransaction DomainToSDK(Domain.Models.AccountTransaction accountTransaction)
        {
            var accountTransactionMapped = new SDK.Models.AccountTransaction
            {
                Id = accountTransaction.Id,
                AccountId = accountTransaction.Id,
                Code = accountTransaction.Code,
                Timestamp = accountTransaction.Timestamp,
                Type = accountTransaction.Type,
                Amount = accountTransaction.Amount
            };

            return accountTransactionMapped;
        }

        public static Domain.Models.AccountTransaction SDKToDomain(SDK.Models.AccountTransaction accountTransaction)
        {
            var accountTransactionMapped = new Domain.Models.AccountTransaction
            {
                Id = accountTransaction.Id,
                AccountId = accountTransaction.Id,
                Code = accountTransaction.Code,
                Timestamp = accountTransaction.Timestamp,
                Type = accountTransaction.Type,
                Amount = accountTransaction.Amount
            };

            return accountTransactionMapped;
        }
    }
}
