using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    [Table(name:"product")]
    public class Product
    {
        [Key]
        [Column(TypeName ="varchar(10)")]
        public string ID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(255)")]
        public string product_name { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string catalog_id { get; set; }
        [Required]
        [Column(TypeName = "integer")]
        public int amount { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal price { get; set; }

    }
}
