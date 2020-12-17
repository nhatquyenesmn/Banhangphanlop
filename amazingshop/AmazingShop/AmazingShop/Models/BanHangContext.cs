using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingShop.Models
{
    public class BanHangContext : DbContext
    {
        public BanHangContext(DbContextOptions<BanHangContext> options) : base(options)
        {

        }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Employee> emloy { get; set; }
        public DbSet<Role> role { get; set; }
        public DbSet<Catalog> cata { get; set; }
        public DbSet<Combo> combo { get; set; }
        public DbSet<Invoice> invoice { get; set; }
        public DbSet<Invoice_detail> in_detail { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Product_Detail> pro_detail { get; set; }
        public DbSet<Storage> storage { get; set; }
        public object Configuration { get; internal set; }
    }
}
