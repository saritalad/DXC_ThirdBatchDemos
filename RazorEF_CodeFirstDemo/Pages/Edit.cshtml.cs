using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorEF_CodeFirstDemo.Models;

namespace RazorEF_CodeFirstDemo.Pages
{
    public class EditModel : PageModel
    {
        private readonly AppDBContext _context;

        public EditModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Department dept { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null || _context.Departments == null)
            {
                return NotFound();
            }
            // select Id,Name from Departments where Id=id
            var department =  _context.Departments.FirstOrDefault(m => m.Id == id);
            if (department == null)
            {
                return NotFound();
            }
            dept = department;
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
            //update departments set name= dept.Name where Id =id in the dataset 
            _context.Attach(dept).State = EntityState.Modified;

            _context.SaveChanges();

            return RedirectToPage("./Index");
        }

        private bool DepartmentExists(int id)
        {
          return (_context.Departments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
