using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using WebApi_ActionResultDemo.Models;

namespace WebApi_ActionResultDemo.Controllers
{
    [Route("api/emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("details/{id}")]
        public IActionResult getEmployeeDetails(int id)
        {
            var emp = Employee.GetEmployees().FirstOrDefault(emp => emp.ID == id);
            if(emp!=null)
            {
                return Ok(emp);

            }
            else
            { 
                return NotFound(" record not found");
            }

        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAllEmployees()
        {
            var data = Employee.GetEmployees();
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest("Expected data not available");
            }

        }


    }
}
