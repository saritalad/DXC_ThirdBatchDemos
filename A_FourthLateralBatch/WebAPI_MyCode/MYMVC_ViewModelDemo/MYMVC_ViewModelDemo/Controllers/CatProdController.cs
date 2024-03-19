using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYMVC_ViewModelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_ViewModelDemo.Controllers
{
    [Route("Product")]
    public class CatProdController : Controller
    {
        public CatProdController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }
        public JsonResult Index()
        {
            var data = _context.Catwiseproducts.FromSqlInterpolated($"dbo.SP_Products_Category");
            return Json(data);
        }

     
        public ActionResult Index1()
        {
            var Cat = _context.Categories.ToList();
            return View(Cat);
        }

       [Route("Details/{id}")]
        public ActionResult Details(int? id)
        {// select * from categories where catid=id
            var cat = _context.Categories.FirstOrDefault(cat => cat.Catid == id);
            List<Product> products = _context.products.Where(p => p.Catid == cat.Catid).ToList();

            CategoryViewModel data = new CategoryViewModel()
            {
                productlist = products,
                category = cat
            };
            return View(data);
        }
    }

}
