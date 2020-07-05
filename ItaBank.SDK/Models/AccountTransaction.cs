using System;

namespace ItaBank.SDK.Models
{
    public class AccountTransaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Code { get; set; }
        public DateTime Timestamp { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
    }
}
