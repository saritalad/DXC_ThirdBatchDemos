using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionS_Demo
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id=3,Name="Bill"});
            students.Add(new Student() { Id = 2, Name = "Mill" });
            students.Add(new Student() { Id = 1, Name = "Jill" });
            students.Add(new Student() { Id = 7, Name = "Nill" });
            students.Add(new Student() { Id = 9, Name = "Gill" });
            Console.WriteLine("......... Sorted List of Students");
            students.Sort();
            foreach(Student student in students) 
            Console.WriteLine(student);
            Student s1=new Student() { Id=9,Name="XYZ"};
            Student s2 = new Student() { Id = 9, Name = "PQR" };
            int result=s1.CompareTo(s2);
            Console.WriteLine("Result ="+result);
        }
    }
}
