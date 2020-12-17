using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    [Table(name:"invoice_detail")]
    public class Invoice_detail
    {
        [Key]
        public int invoicede_id { get; set; }
        [Required]
        [Column(TypeName ="varchar(10)")]
        public string invoice_id { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string product_id { get; set; }
        [Column(TypeName = "text")]
        public string combo_id { get; set; }
        [Required]
        [Column(TypeName = "integer")]
        public int amount { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal price { get; set; }
    }
}
