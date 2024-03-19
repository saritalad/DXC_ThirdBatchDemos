using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollections
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 3, Name = "Bill" });
            students.Add(new Student() { Id = 2, Name = "Mill" });
            students.Add(new Student() { Id=15,Name="Jill"});
            students.Add(new Student() { Id = 4, Name = "Nill" });
            students.Add(new Student() { Id = 7, Name = "Gill" });
           students.Sort();
            Console.WriteLine(".....Sorted List of Students");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            Student s1 = new Student() { Id = 2, Name = "Aksha" };
            Student s2 = new Student() { Id = 2, Name = "Manoj" };
            int result=s1.CompareTo(s2);

            Console.WriteLine("Comparison gives result "+result);
        }
    }
}
