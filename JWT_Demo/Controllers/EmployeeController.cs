using JWT_Demo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context) { _context=context; }
        [HttpGet]
        [Authorize]
        [Route("Getdata")]
        public ActionResult<IEnumerable<Employee>>Getdata()
        {
            return _context.Employee.ToList(); ;
        }
        [HttpGet]

        [Route("Getdetails")]
        public string Details()
        {
            return "Authorized with JWT";
        }
    }
}
