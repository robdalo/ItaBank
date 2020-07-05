using System.Collections.Generic;

namespace ItaBank.SDK.Models
{
    public class Account
    {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public List<AccountTransaction> Transactions { get; set; }
    }
}
