using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    [Table(name:"product_detail")]
    public class Product_Detail
    {
        [Key]
        [Column(TypeName ="varchar(10)")]
        public string product_id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(650)")]
        public string product_detail { get; set; }
        [Required]
        [Column(TypeName = "varchar(650)")]
        public string product_img { get; set; }

    }
}
