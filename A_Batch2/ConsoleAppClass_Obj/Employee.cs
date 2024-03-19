using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass_Obj
{
    enum Department { HR,IT,Civil,Sales,Electrical,Accounts}
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Date Doj { get; set; }
        public Department department { get; set; }
        public static int Count { get; set; }
        public Employee() {
        Id= 100;
        Name= "Bill ";
            Salary= 10000;
            Doj=new Date();
            department =Department.HR;
            Count++;
           }
       
        public Employee(int id,string Name,decimal Salary,Date Doj,Department dept) 
        {
            Id = id;
            this.Name = Name;
            this.Salary = Salary;
            this.Doj = Doj;
            this.department = dept; 
            Count++;
        }
        public override string ToString() 
        {
            return "Employee Details:" + Id + "Name :" + Name + "\n" + "Salary:" + Salary + "\nDate Of Joining :" + Doj
                + " Department :" + department;
        }

        public static void ShowCount() {
            Console.WriteLine($"Total count of Employees {Employee.Count}");
        }

    }
}
