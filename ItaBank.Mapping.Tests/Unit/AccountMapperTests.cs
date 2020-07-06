using ItaBank.Domain.Models;
using ItaBank.Mapping;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ItaBank.Core.Tests.Integration.Services
{
    public class AccountMapperTests
    {
        public AccountMapperTests()
        {
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DomainToSDK_MapsOK()
        {
            var now = DateTime.Now;

            var accountTransaction1 = new AccountTransaction
            {
                Id = 1,
                AccountId = 1,
                Code = "AT0001",
                Timestamp = now,
                Type = "CR",
                Amount = 25000
            };

            var accountTransaction2 = new AccountTransaction
            {
                Id = 2,
                AccountId = 1,
                Code = "AT0002",
                Timestamp = now,
                Type = "CR",
                Amount = 35000
            };

            var account = new Account
            {
                Id = 1,
                Code = "AC0001",
                Name = "Mr Rob Daley",
                Address = "10 Downing Street, Westminster, London, EC1 1LV",
                Balance = 75000,
                Transactions = new List<AccountTransaction>()
                    {
                        accountTransaction1,
                        accountTransaction2
                    }
            };

            var accounts = new List<Account>()
            {
                account
            };

            var accountsMapped = AccountMapper.DomainToSDK(accounts);
            var accountMapped = accountsMapped.First();
            var accountTransaction1Mapped = accountMapped.Transactions.First();
            var accountTransaction2Mapped = accountMapped.Transactions.Last();

            Assert.IsTrue(
                accountMapped.Id == account.Id &&
                accountMapped.Code == account.Code &&
                accountMapped.Name == account.Name &&
                accountMapped.Address == account.Address &&
                accountMapped.Balance == account.Balance &&
                accountTransaction1Mapped.Id == accountTransaction1.Id &&
                accountTransaction1Mapped.AccountId == accountTransaction1.AccountId &&
                accountTransaction1Mapped.Code == accountTransaction1.Code &&
                accountTransaction1Mapped.Timestamp == accountTransaction1.Timestamp &&
                accountTransaction1Mapped.Type == accountTransaction1.Type &&
                accountTransaction1Mapped.Amount == accountTransaction1.Amount &&
                accountTransaction2Mapped.Id == accountTransaction2.Id &&
                accountTransaction2Mapped.AccountId == accountTransaction2.AccountId &&
                accountTransaction2Mapped.Code == accountTransaction2.Code &&
                accountTransaction2Mapped.Timestamp == accountTransaction2.Timestamp &&
                accountTransaction2Mapped.Type == accountTransaction2.Type &&
                accountTransaction2Mapped.Amount == accountTransaction2.Amount
            );
        }
    }
}
