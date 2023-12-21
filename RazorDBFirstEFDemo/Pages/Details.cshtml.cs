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
    public class DetailsModel : PageModel
    {
        private readonly RazorDBFirstEFDemo.Models.AppDBContext _context;

        public DetailsModel(RazorDBFirstEFDemo.Models.AppDBContext context)
        {
            _context = context;
        }

      public Product Product { get; set; } = default!; 

        public IActionResult OnGet(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product =  _context.Products.FirstOrDefault(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }
    }
}
