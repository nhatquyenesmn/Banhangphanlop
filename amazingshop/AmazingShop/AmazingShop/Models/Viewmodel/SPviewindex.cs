using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models.Viewmodel
{
    public class SPviewindex
    {
        public string ID { get; set; }
        public string product_name { get; set; }
        public string catalog_name { get; set; }
        public int amount { get; set; }
        public decimal price { get; set; }
        public string product_id { get; set; }
        public string product_detail { get; set; }
        public string product_img { get; set; }
    }
}
