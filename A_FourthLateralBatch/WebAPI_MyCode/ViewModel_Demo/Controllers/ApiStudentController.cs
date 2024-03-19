using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Demo.Models;
using ViewModel_Demo.Viewmodels;

namespace ViewModel_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiStudentController : ControllerBase
    {
        [HttpGet]
        public ActionResult Details()
        {
            Student student = new Student()
            {
                StudentId = 101,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            //Student Address
            Address address = new Address()
            {
                StudentId = 101,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };
            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",
            };
            return Ok(studentDetailsViewModel);
        }
    }
}
