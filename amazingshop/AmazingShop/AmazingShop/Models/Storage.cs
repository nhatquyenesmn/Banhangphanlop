using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    [Table(name:"storage")]
    public class Storage
    {
        [Key]
        public int storage_id { get; set; }
        [Required]
        [Column(TypeName ="text")]
        public string product_id { get; set; }
        [Required]
        [Column(TypeName ="decimal(10,0)")]
        public decimal total { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime importDate { get; set; }
    }
}
