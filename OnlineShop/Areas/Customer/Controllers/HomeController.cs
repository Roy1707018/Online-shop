using System;
using System.Web;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;
using OnlineShop.Utility;
using X.PagedList;
using Microsoft.AspNetCore.Http;

namespace OnlineShop.Controllers
{
    [Area("Customer")]
   
    public class HomeController : Controller
    {
        private ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? page)
        {
            return View(_db.Products.Include(c => c.ProductTypes).ToList().ToPagedList(page ?? 1, 9));
        }
        


        public IActionResult Privacy()
        {
          /*  String k = "Cookie";
            String v = "ashopopo";
            
            CookieOptions cookie = new CookieOptions('name');
            cookieOptions.Expires = DateTime.Now.AddDays(1);
          
            Response.Cookies.Append(k, v, cookieOptions);*/
            var options = new CookieOptions
            {
           
                Expires = DateTime.Now.AddDays(3)
            };

            var requ = Request.Cookies["user"];
            string y = "";

           

            if (requ == null)
            {
                //y = DateTime.Now.ToString();
                y = "Enjoy Shopping";
               
                Response.Cookies.Append("user", y);
                //Response.WriteAsync("hihi");
                ViewBag.y = y;

                return View();
            }
            else
            {
                y = Request.Cookies["user"];
                ViewBag.y = y;

                return View();

            }


           // return View();

        }

        /*[HttpPost]
        public IActionResult Privacy(IFormCollection fc)
        {
            /*CookieOptions options = new CookieOptions();
             
           options.Expires = DateTime.Now.AddDays(9);
            Response.Cookies.Append("name", fc["txtcookei"], options);*/
            //return RedirectToAction("Privacy", "Home");
        
    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //GET product detail acation method
        [Authorize]
        public ActionResult Detail(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var product = _db.Products.Include(c => c.ProductTypes).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //POST product detail acation method
        [HttpPost]
        [ActionName("Detail")]
        [Authorize]
        public ActionResult ProductDetail(int? id)
        {
            List<Products> products = new List<Products>();
            if (id == null)
            {
                return NotFound();
            }

            var product = _db.Products.Include(c => c.ProductTypes).FirstOrDefault(c => c.Id == id);
            //int typeid=
            if (product == null)
            {
                return NotFound();
            }
            products = HttpContext.Session.Get<List<Products>>("products");
            if (products == null)
            {
               

                products = new List<Products>();
            }
            products.Add(product);
            HttpContext.Session.Set("products", products); 

            return RedirectToAction(nameof(Index));
        }
        //GET Remove action methdo
        [ActionName("Remove")]
        [Authorize]
        public IActionResult RemoveToCart(int? id)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                var product = products.FirstOrDefault(c => c.Id == id);
                if (product != null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction(nameof(Cart));
        }
        [HttpPost]
        [Authorize]
        public IActionResult Remove(int? id)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                var product = products.FirstOrDefault(c => c.Id == id);
                if (product != null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction(nameof(Index)); 
        }
        [Authorize]
        public IActionResult Cart()
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products == null)
            {
                products = new List<Products>();
            }
            return View(products);
        }
    }
}

