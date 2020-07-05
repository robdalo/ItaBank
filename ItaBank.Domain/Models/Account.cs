using System.Collections.Generic;

namespace ItaBank.Domain.Models
{
    public class Account
    {
        public int Id;
        public string Number;
        public string Name;
        public string Address;
        public decimal Balance;
        public List<Transaction> Transactions;
    }
}
