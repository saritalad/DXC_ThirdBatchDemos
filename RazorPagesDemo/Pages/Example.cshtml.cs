using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class ExampleModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }
        public  List<string> fruits =  new List<string>(){"Apple","Banana","Orange","Mango","Grapes"};
    }
}
