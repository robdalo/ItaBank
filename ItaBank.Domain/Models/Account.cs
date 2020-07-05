using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItaBank.Domain.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string Code { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public List<AccountTransaction> Transactions { get; set; }
    }
}
