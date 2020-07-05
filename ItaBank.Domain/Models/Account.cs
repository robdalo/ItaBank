using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ItaBank.Domain.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string Number { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
