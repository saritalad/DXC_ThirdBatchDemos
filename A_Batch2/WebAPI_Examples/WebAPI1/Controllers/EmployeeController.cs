using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebAPI1.Controllers
{
    [Route("api/emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("Details/{id}")]
        public IActionResult Get(int id)
        {
            var data=Employee.GetEmployees().FirstOrDefault(e=>e.ID==id);
            if(data!=null)
            {
                return Ok(data);
            }
            else
            { return BadRequest();
            }

        }


        [HttpGet]
        [Route("AllEmployees")]
        public ActionResult Get()
        {
            var data = Employee.GetEmployees();
            if(data!=null)
            {
                return Ok(data);
            }
            else
            { return NotFound();
            }
        }
    }
}
