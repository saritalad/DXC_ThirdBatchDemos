using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAction()
        {
            List<Student> students = Student.GetStudents();
            return Ok(students);
        }
        [HttpPost]
        public ActionResult post(Student newstud)
        {
            List<Student> students = Student.GetStudents();
            students.Add(newstud);
            return Ok(newstud);
        }
            
    }
}
