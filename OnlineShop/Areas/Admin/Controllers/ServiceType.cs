using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Models;
using System.Data.SqlClient;


namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceTypeController : Controller
    {
        
        private ApplicationDbContext _db;

        public ServiceTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.ServiceTypes.ToList());
        }
        //GET Create Action Method
        //[Authorize]
        public ActionResult Create()
        {
            return View();
        }

        //POST Create Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServiceTypes serviceTypes)
        {
            if (ModelState.IsValid)
            {

                _db.ServiceTypes.Add(serviceTypes);
                await _db.SaveChangesAsync();
                //TempData["save"] = "Service type has been saved";
                return RedirectToAction(nameof(Index));
            }

            return View(serviceTypes);
        }
        //GET Edit Action Method

        // [Authorize]
        


       

        
        //GET Delete Action Method
        // [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = _db.ServiceTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View();
        }

        //POST Delete Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, ServiceTypes serviceTyp)
        {

            /*if  (ModelState.IsValid) { 
                    _db.Remove(serviceTyp);
                await _db.SaveChangesAsync();
                TempData["delete"] = "service type has been deleted";
                return RedirectToAction(nameof(Index));
                }*/
            var result = from ur in _db.ServiceTypes
                         where ur.ServiceId == id
                         select ur;
           foreach (var ur in result)
            {
                _db.ServiceTypes.Remove(ur);
            }

            await _db.SaveChangesAsync();
           // TempData["delete"] = "Product type has been deleted";
            return RedirectToAction(nameof(Index));


        }
    }
}