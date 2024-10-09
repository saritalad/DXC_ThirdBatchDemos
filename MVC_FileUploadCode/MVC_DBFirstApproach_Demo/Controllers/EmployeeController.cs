using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_DBFirstApproach_Demo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DBFirstApproach_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        public EmployeeController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
             _hostingEnvironment= hostingEnvironment;
        }

        public IActionResult Index()
        {
            
            var emplist = _context.Employees.ToList();
            if (emplist != null)
                return View(emplist);
            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var deptlist = from dep in _context.Departments
                           select new SelectListItem()
                           {
                               Text = dep.Name,
                               Value = dep.Id.ToString()
                           };
            ViewBag.departments = deptlist;



            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateViewModel model)
        {

            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.Photo != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Employee newEmployee = new Employee
                {
                    Name = model.Name,
                    Salary = model.Salary,
                    deptId = model.deptId,
                    Doj = model.Doj,
                    gender = model.gender,
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    Photopath = uniqueFileName
                };
                _context.Employees.Add(newEmployee);
                _context.SaveChanges();

                return RedirectToAction("details", new { id = newEmployee.Id });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var data = _context.Employees.FirstOrDefault(e => e.Id == id);
            if(data!=null)
            {
                return View(data);
            }

            return RedirectToAction("Index");
        }




        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var deptlist=from dep in _context.Departments
                  select new SelectListItem()
                  {
                      Text = dep.Name,
                      Value = dep.Id.ToString()
                  };
            ViewBag.departments = deptlist;
            if (id == null)
            {
                return BadRequest();
            }
            //select Id,name,Salary, doj, deptId from employees where Id =id
            var emp = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(int? id, Employee modified)
        {
            var olddata = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (ModelState.IsValid)
            {// update employees set Name=name........ where Id =id
                olddata.Name = modified.Name;
                olddata.Salary = modified.Salary;
                olddata.Doj = modified.Doj;
                olddata.deptId = modified.deptId;
                olddata.gender = modified.gender;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(modified);
        }


    }
}
