using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINk_Lambda_Demo
{
    internal class Program4_Where
    {
        static void Main()
        {
            //List<Student> Studlist = Student.GetStudents().Where(s=>s.Gender=="Male").ToList();
            //Console.WriteLine("...... List of Male Students ........");
            //foreach (Student student in Studlist)
            //{
            //    Console.WriteLine(student.Name+" "+student.Gender);
            //}

            // Single , SingleOrDefault
            // First , FirstOrDefaullt
            int[] numbers = { 1, 2, 4, 71, 219, 9, 8, 10, 11, 12, 13};
            //var div7=numbers.Single(n=>n%7==0);
            //var div7=numbers.First(n=>n%7==0);
            // int div7= numbers.SingleOrDefault(n => n % 7 == 0);
             int div7= numbers.FirstOrDefault(n => n % 7 == 0);
            Console.WriteLine("Number Divisible By 7 is "+div7);

            // default value is zero 
            int x;
            float y;

        }
    }
}
