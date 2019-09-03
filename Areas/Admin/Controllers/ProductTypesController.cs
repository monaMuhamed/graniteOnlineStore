using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using raniteOnlineStore.Data;
using raniteOnlineStore.Models;

namespace raniteOnlineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        public readonly Data.ApplicationDbContext _db;


        public ProductTypesController(ApplicationDbContext db)
            {
                _db = db;
            }
        public IActionResult Index()
        {
            return View(_db.ProductTypes.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }       

        [HttpPost]
        public IActionResult Create(ProductTypes productTypes)
        {
            if(ModelState.IsValid)
            {
                _db.Add(productTypes);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View();

        }
    }
}