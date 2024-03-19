using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
