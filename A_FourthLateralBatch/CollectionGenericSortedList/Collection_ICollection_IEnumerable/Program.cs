using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_ICollection_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id=1,Name="Sarita"},
                  new Student(){Id=2,Name="Rita"},
                    new Student(){Id=3,Name="Smita"},
            };
           // ICollection<Student> collection = students;
            IEnumerable<Student> collection = students;
          // collection.Add(new Student() { Id = 4, Name = "Ameet" });
            foreach(Student s in collection)
                Console.WriteLine(s.Id+" " +s.Name);
        }
    }
}
