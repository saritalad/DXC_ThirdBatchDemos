using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorDBFirstEFDemo.Models;

namespace RazorDBFirstEFDemo.Pages
{
    public class EditModel : PageModel
    {
        private readonly RazorDBFirstEFDemo.Models.AppDBContext _context;

        public EditModel(RazorDBFirstEFDemo.Models.AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }
                                     // select * from products where Id=id
            var productdata =   _context.Products.FirstOrDefault(m => m.Id == id);
            if (productdata == null)
            {
                return NotFound();
            }
            Product = productdata;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // update Products set ProductName= Productdata.productname,
            // in dataSet
            _context.Attach(Product).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(Product.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductExists(int id)
        {
          return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
