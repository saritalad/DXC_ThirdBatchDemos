using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYWeb_API_Routing_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeConstraintController : ControllerBase
    {
        [Route("{EmployeeId:int}")]
        public string GetEmployeeDetails(int EmployeeId)
        {
            return $"Response from GetEmployeeDetails Method, EmployeeId : {EmployeeId}";
        }
        [Route("{EmployeeName}")]
        public string GetEmployeeDetails(string EmployeeName)
        {
            return $"Response from GetEmployeeDetails Method, EmployeeName : {EmployeeName}";
        }
    }
}
