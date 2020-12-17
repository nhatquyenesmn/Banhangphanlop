using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    [Table(name:"combo")]
    public class Combo
    {
        [Key]
        [Column(TypeName ="varchar(10)")]
        public string ID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(255)")]
        public string combo_name { get; set; }
        [Required]
        [Column(TypeName = "Text")]
        public string product_list { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime startDate { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime endDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal totalMoney { get; set; }
        [Required]
        [Column(TypeName = "varchar(8)")]
        public string discount { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal discountMoney { get; set; }
    }
}
