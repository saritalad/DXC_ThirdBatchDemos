using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEF_CodeFirstDemo.Models;

namespace RazorEF_CodeFirstDemo.Pages
{
    public class CreateModel : PageModel
    {
        public AppDBContext _context { get; set; }
        [BindProperty]
        public Department dept { get; set; }
        public CreateModel(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }



        public IActionResult OnPost() {

            //if (!ModelState.IsValid || _context.Departments == null || dept == null)
            //{
            //    return Page();


            //}
            // insert into departments values 'HR';
            _context.Departments.Add(dept);
            _context.SaveChanges();
        
        return RedirectToPage("./Index");
        }
     }
}
