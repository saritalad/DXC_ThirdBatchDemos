using System;

namespace ConsoleAppClass_Obj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student s1=new Student();
         //   Console.WriteLine($"{s1.Id} {s1.Name} {s1.Marks}");
            Student s2=new Student(2,"Mill",78,new Date(12,3,2023));
          //  Console.WriteLine($"Student Details :{s2.Id} {s2.Name} {s2.Marks}");

           // s2.Id = 100; readonly becoz set is missing
          //  s2.Name = "John";
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            // s1.ShowResult();
            // s2.ShowResult();
            //Date Today=new Date(23,2,2024);
            //Student s3=new Student(3,"Jill",32,Today);
            //Console.WriteLine(s3);
            //Console.WriteLine(Today);
            Employee employee=new Employee();
            Employee E2 = new Employee();
            Employee E3 = new Employee(23,"Nill",34000,new Date(2,2,2023),Department.IT);
            Console.WriteLine(employee);
            Console.WriteLine(E2.GetType());
           
          
            Console.WriteLine(s1.GetType());
            // Employee.ShowCount();
            Product p1 = new Product("Biscuits", "Indian Biscuit");
            Product.DisplayCount();

        }
    }
}
