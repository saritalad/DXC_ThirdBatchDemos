using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lammbda_Demo
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            var query = from s in Student.GetStudents().GroupBy(g=>g.Gender) 
                        select s;
          //foreach (var gp in query)
          //  {
          //      Console.WriteLine(gp.Key + " count is "+gp.Count());
          //      foreach(var s in gp)
          //      {
          //          Console.WriteLine(s.ID+ " "+s.Name+" "+s.Branch);
          //      }

          //  }
          // Where operator 

            var query1 = Student.GetStudents().Where(s => s.Gender == "Female").ToList();
            foreach (var s in query1)
            { Console.WriteLine(s.ID + " " + s.Name + " " + s.Gender); }



            Console.WriteLine("..............................");
            int[] Number = { 1, 2, 4, 6,  145,17, 34, 15, 211 };
            //  var div7 = Number.Single(n => n % 7 == 0); multiple numbers div by 7 error
             //var div7 = Number.First(n => n % 7 == 0);
            // var div7 = Number.Single(n => n % 7 == 0);
           var div7 = Number.FirstOrDefault(n => n % 7 == 0);// if no condition fullfilled 
            // then default value is displayed
            Console.WriteLine("Number divisible by 7 is "+div7);

        }
    }
}
