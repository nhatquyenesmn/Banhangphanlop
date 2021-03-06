﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    [Table(name:"customer")]
    public class Customer
    {
        [Key]
        [Column(TypeName = "varchar(10)")]
        public string ID { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public string username { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string password { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string firstname { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string lastname { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string gender { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime birthDay { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string address { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string phone { get; set; }
        public DateTime joinDate { get; set; }

        internal bool Checkusername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
