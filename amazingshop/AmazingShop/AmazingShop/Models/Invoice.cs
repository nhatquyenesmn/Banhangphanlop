using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    [Table(name:"invoice")]
    public class Invoice
    {
        [Key]
        [Column(TypeName ="varchar(10)")]
        public string ID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(45)")]
        public string invoice_name { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string customer_id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string customer_name { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string shipper_id { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal total_money { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime create_day { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string customer_address { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string customer_phone { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime ship_date { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string trangthai { get; set; }
    }
}
