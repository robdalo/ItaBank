using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItaBank.Domain.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Account")]
        public int AccountId { get; set; }
        [StringLength(20)]
        public string Code { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Amount { get; set; }
        [StringLength(20)]
        public string Type { get; set; }
    }
}
