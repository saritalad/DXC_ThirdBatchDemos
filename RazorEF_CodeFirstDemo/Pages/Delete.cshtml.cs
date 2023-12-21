using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorEF_CodeFirstDemo.Models;

namespace RazorEF_CodeFirstDemo.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly AppDBContext _context;

        public DeleteModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Department Department { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null || _context.Departments == null)
            {
                return NotFound();
            }

            var department = _context.Departments.FirstOrDefault(m => m.Id == id);

            if (department == null)
            {
                return NotFound();
            }
            else 
            {
                Department = department;
            }
            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null || _context.Departments == null)
            {
                return NotFound();
            }
            var department = _context.Departments.Find(id);

            if (department != null)
            {
                Department = department;
                _context.Departments.Remove(Department);// from data set  removed obj
                _context.SaveChanges();// updated new change in dataset to database table department
            }

            return RedirectToPage("./Index");
        }
    }
}
