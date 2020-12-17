using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    [Table(name:"role")]
    public class Role
    {
        [Key]
        [Column(TypeName ="varchar(10)")]
        public string ID { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string role_name { get; set; }
    }
}
