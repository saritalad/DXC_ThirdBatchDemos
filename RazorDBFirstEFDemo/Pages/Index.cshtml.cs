using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorDBFirstEFDemo.Models;


namespace RazorDBFirstEFDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _context;
        //constor inject AppdbContext
        public IndexModel(AppDBContext context)
        {
            _context = context;
        }

        public IList<Product> Productlist { get;set; } = default!;

        public void OnGet()
        {
            if (_context.Products != null)
            {   // select * from Products   is fired at DB
                Productlist =  _context.Products.ToList();
            }
        }
    }
}
