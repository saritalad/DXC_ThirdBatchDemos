using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorEF_CodeFirstDemo.Models;

namespace RazorEF_CodeFirstDemo.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly AppDBContext _context;

        public DetailsModel(AppDBContext context)
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
            // select * from departments where id=id
            var department =  _context.Departments.FirstOrDefault(m => m.Id == id);
            if (department == null)
            {
                return NotFound();
            }
            else
            {
                dept = department;
            }
            return Page();
        }
    }
}
