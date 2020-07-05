namespace ItaBank.Core.Mapping
{
    public static class AccountTransactionMapper
    {
        public static SDK.Models.AccountTransaction Map(Domain.Models.AccountTransaction accountTransaction)
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
    }
}
