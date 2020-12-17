using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AmazingShop.Models;
using AmazingShop.Models.Viewmodel;

namespace AmazingShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly BanHangContext _context;

        public HomeController(BanHangContext context)
        {
            _context = context;
        }
        public IEnumerable<Catalog> travecata()
        {
            return _context.cata.ToList();
        }
        public IEnumerable<SPviewindex> showpro()
        {
            return _context.product.Join(
                _context.pro_detail,
                sp1 => sp1.ID,
                sp_de => sp_de.product_id,
                (sp1,sp_de) => new {sp1,sp_de}
                ).Join(
                _context.cata,
                sp2 => sp2.sp1.catalog_id,
                cata => cata.ID,
                (sp2,cata) => new SPviewindex
                {
                    ID = sp2.sp1.ID,
                    product_name = sp2.sp1.product_name,
                    product_img = sp2.sp_de.product_img,
                    catalog_name = cata.catalog_name,
                    amount = sp2.sp1.amount,
                    price = sp2.sp1.price
                }
                ).ToList();
        }
        public IActionResult Index()
        {
            ViewData["catalog"] = travecata();
            ViewData["product"] = showpro();
            return View();
        }

        public IActionResult Login()
        {
            ViewData["catalog"] = travecata();
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            ViewData["catalog"] = travecata();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Customer _user)
        {
            if (ModelState.IsValid)
            {
                var check = _context.customer.FirstOrDefault(s => s.phone == _user.phone);
                if (check == null)
                {
                    _user.password = GetMD5(_user.password);
                 //   _context.Configuration.ValidateOnSaveEnabled = false;
                    _context.customer.Add(_user);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Phone already exists";
                    return View();
                }


            }
            return View();


        }

        private string GetMD5(string password)
        {
            throw new NotImplementedException();
        }

        public IActionResult Category()
        {
            ViewData["catalog"] = travecata();
            ViewData["product"] = showpro();
            return View();
        }
        public IActionResult ProductDetails()
        {
            ViewData["catalog"] = travecata();
            return View();
        }
        public IActionResult Checkout()
        {
            ViewData["catalog"] = travecata();
            return View();
        }
        public IActionResult Cart()
        {
            ViewData["catalog"] = travecata();
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["catalog"] = travecata();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
