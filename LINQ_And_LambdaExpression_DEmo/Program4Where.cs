using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_And_LambdaExpression_DEmo
{
    internal class Program4Where
    {
        public static void Main()
        {
            Console.WriteLine("\n............... example of Female students using Where extension methods..........\n");
            List<Student> studlist = Student.GetStudents().Where(s => s.Gender == "Female").ToList();
            foreach (var student in studlist)
            {

                Console.WriteLine(student.Name + " " + student.Gender);

            }

            Console.WriteLine("------------------------------------------");
            var query= from s in Student.GetStudents()
                       where s.Gender=="Female"
                       select s;
            foreach(var student in query)
            {
                Console.WriteLine(student.Name + "  "+ student.Gender);
            }
            Console.WriteLine("..employee list with list of Technologies for indivisual Employee ..........");
            //   Method Syntax
            var MethodSyntax = Employee1.GetEmployees()
                               .Where(emp => emp.Salary > 50000 && emp.Gender == "Male")
                               .ToList();

            foreach (var emp in MethodSyntax)
            {
                Console.WriteLine($"Name : {emp.Name}, Salary : {emp.Salary}, Gender : {emp.Gender}");
                if (emp.Technology != null && emp.Technology.Count() > 0)
                {
                    Console.Write(" Technology : ");
                    foreach (var tech in emp.Technology)
                    {
                        Console.Write(tech + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" Technology Not Available ");
                }
            }
        }
    }
}
