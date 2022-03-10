using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using OnlineShop.Data;
using OnlineShop.Models;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderServiceController : Controller
    {
        private ApplicationDbContext _db;
        public OrderServiceController(ApplicationDbContext db)
        {
           _db = db;
          
        }
        public IActionResult Index()
        {
            ViewData["ServiceTypeId"] = new SelectList(_db.ServiceTypes.ToList(), "ServiceId", "ServiceType");
            
            return View();
           
        }
        [HttpPost]
        public async Task<IActionResult> Index(OrderService orderService)
        {
            /*if (ModelState.IsValid)
            {
                var searchProduct = _db.OrderService.FirstOrDefault(c => c.Name == product.Name);
                if (searchProduct != null)
                {
                    ViewBag.message = "This product already exists";
                    ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
                    //ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "Name");
                    return View(product);
                }*/

               
                _db.OrderService.Add(orderService);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index","ServiceType");
            

           // return View(orderService);
        }
        public ActionResult Details(int? id)
        {

            return View(_db.OrderService.Include(c => c.ServiceTypes).ToList());
        }


    }
}