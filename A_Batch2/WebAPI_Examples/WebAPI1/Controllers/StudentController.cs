using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI1.Controllers
{
                            //[token]
             //[Route("api/[controller])
    [Route("api/stud")]
    [ApiController]//attribute 
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        [Route("AllStudents")]
        public ActionResult Get()
        { // select query
            List<Student> studlist=Student.GetStudents();

            return Ok(studlist);
               
        }
        [HttpGet]
        [Route("GetStudent/{id}")]
        public IActionResult Details(int id)
        {
            var data = Student.GetStudents().FirstOrDefault(s => s.ID == id);
            if(data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }






        [HttpPost]
        public ActionResult Post(Student newstudent)
        {
            // insert query
            List<Student>studlist=Student.GetStudents();
            studlist.Add(newstudent);
            return Ok(studlist);
        }



    }
}
