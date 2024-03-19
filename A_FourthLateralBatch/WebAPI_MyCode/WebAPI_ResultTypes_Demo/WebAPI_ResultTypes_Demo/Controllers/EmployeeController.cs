using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_ResultTypes_Demo.Models;

//In ASP.NET Core Web API, in three different ways, we can return data
//from the controller action method. They are as follows:
//Specific type
//https://dotnettutorials.net/lesson/controller-action-return-types-core-web-api/
//IActionResult
//ActionResult<T>



namespace WebAPI_ResultTypes_Demo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("Name")]
        public string GetName()
        {
            return "Return from GetName";
        }
        //Returning Complex Type in ASP.NET Core Web API:
        [Route("Details")]
        public Employee GetEmployeeDetails()
        {
            return new Employee()
            {
                Id = 1001,
                Name = "Anurag",
                Age = 28,
                City = "Mumbai",
                Gender = "Male",
                Department = "IT"
            };
           

        }
        [Route("GetEmployee/{id}")]
        public IActionResult GetEmployeeDetails(int Id)
        {
            //In Real-Time, you will get the data from the database
            //Here, we have hardcoded the data
            var listEmployees = new List<Employee>()
            {
                    new Employee(){ Id = 1001, Name = "Anurag", Age = 28, City = "Mumbai", Gender = "Male", Department = "IT" },
                    new Employee(){ Id = 1002, Name = "Pranaya", Age = 28, City = "Delhi", Gender = "Male", Department = "IT" },
                    new Employee(){ Id = 1003, Name = "Priyanka", Age = 27, City = "BBSR", Gender = "Female", Department = "HR"},
            }; //Fetch the Employee Data based on the Employee Id
            var employee = listEmployees.FirstOrDefault(emp => emp.Id == Id);
            //If Employee Exists Return OK with the Employee Data
            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {   //If Employee Does Not Exists Return NotFound
                return NotFound();
            }
        }

        //[HttpGet("GetEmployeeDetails/{Id}")]
        //public ActionResult<Employee> GetEmployeeDetails(int Id)
        //{
        //    if (Id == 0)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return new Employee() { Id = 1001, Name = "Anurag", Age = 28, City = "Mumbai", Gender = "Male", Department = "IT" };
        //    }
        //}
        [Route("All")]
        public IActionResult GetAllEmployee()
        {
            var listEmployees = new List<Employee>()
            {
                new Employee(){ Id = 1001, Name = "Anurag", Age = 28, City = "Mumbai", Gender = "Male", Department = "IT" },
                new Employee(){ Id = 1002, Name = "Pranaya", Age = 28, City = "Delhi", Gender = "Male", Department = "IT" },
                new Employee(){ Id = 1003, Name = "Priyanka", Age = 27, City = "BBSR", Gender = "Female", Department = "HR"},
            };
            //If at least of Employee is Present return OK status code and the list of employees
            if (listEmployees.Any())
            {
                return Ok(listEmployees);
            }
            else
            {
                //If no Employee is Present return Not Found Status Code
                return NotFound();
            }
        }
    }





    }

