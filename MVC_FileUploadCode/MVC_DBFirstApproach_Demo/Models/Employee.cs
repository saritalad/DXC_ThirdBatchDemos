using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DBFirstApproach_Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime Doj { get; set;}
        public int deptId { get; set; }
        public string gender { get; set; }
        public string Photopath { get; set; }
    }
}
