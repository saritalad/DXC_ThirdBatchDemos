using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYWeb_API_Routing_Demo.Controllers
{     // base route is api/Employee
    [Route("api/emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //[HttpGet("emp/all")]
        //public string GetAllEmployees()
        //{
        //    return "All Employees";
        //}

       


        [Route("byId/{id}")]
        public string GetEmployeeById(int id)
        {

            return $"Return Employee Details : {id}";
        }


        [Route("Gender/{Gender}/City/{CityId}")]
        public string GetEmployeesByGenderAndCity(string Gender, int CityId)
        {
            return $"Return Employees with Gender : {Gender}, City: {CityId}";
        }
        // passing multiple querystrings   ?department= value&genden=vale&city=value
        //  http://localhost:20798/api/Employee/Employee/search/?department=it&gender=male&city=nagpur
      
        
        [Route("Search")]
        public string SearchEmployees(string Department, string Gender, string City)
        {

            return $"Return Employees with Department : {Department}, Gender : {Gender}, City : {City}";
        
        }

        [Route("Employee/All")]
        [Route("AllEmployees")]
        [Route("Employee/GetAll")]
        public string GetAllEmployees()
        {
            return "Response from GetAllEmployees Method";
        }
        [Route("~/department/all")]
        public string GetAllDepartment()
        {
            return "Response from GetAllDepartment Method";
        }
    }
}
