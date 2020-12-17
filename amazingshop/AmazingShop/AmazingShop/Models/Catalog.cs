using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    [Table(name:"catalog")]
    public class Catalog
    {
        [Key]
        [Column(TypeName ="varchar(10)")]
        public string ID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(25)")]
        public string catalog_name { get; set; }
    }
}
