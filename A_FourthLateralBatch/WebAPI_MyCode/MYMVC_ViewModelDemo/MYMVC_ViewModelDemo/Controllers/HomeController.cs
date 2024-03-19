using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MYMVC_ViewModelDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MYMVC_ViewModelDemo.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult StudentDetails()
        {
            Student s1 = new Student() { StudentId = 1, Name = "Bill", Branch = "IT" };
            Address a1 = new Address() { StudentId = 1, City = "Pune", PIn = "411032" };

            StudentDetailsViewModel S = new StudentDetailsViewModel()
            {
                student = s1,
                address = a1,
                Title = "Topper of University",
                University = "Pune University"

            };
                      return View(S);


        }




        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
