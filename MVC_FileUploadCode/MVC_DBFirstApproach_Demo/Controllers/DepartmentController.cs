using Microsoft.AspNetCore.Mvc;
using MVC_DBFirstApproach_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DBFirstApproach_Demo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var deptlist = _context.Departments.ToList();
            return View(deptlist);
        }
    }
}
