using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEF_CodeFirstDemo.Models;

namespace RazorEF_CodeFirstDemo.Pages
{
    public class IndexModel : PageModel
    {
         public AppDBContext _context { get; set; }
        
        [BindProperty]
      public  List<Department>deptlist { get; set; }

        public IndexModel(AppDBContext context)
        {
          _context=context;
        }

        public void OnGet()
        {
                    //select * from departments
            deptlist= _context.Departments.ToList();


        }
    }
}