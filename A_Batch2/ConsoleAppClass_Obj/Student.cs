using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass_Obj
{// Containment Example
    
    internal class Student
    {// DATA members
        public int Id { get; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public Date Doa { get; set; }// object of Date class is available as a data member in Student class
        // default constructor
        public Student()
        {
            Id = 10;
            Name = "Bill";
            Marks = 50;
            Doa= new Date();
        }
        // parameterized construtor
        public Student(int id,string name,int mark,Date doa)
        {
            Id = id;
            Name = name;
            Marks = mark;
            Doa = doa;
        }
        // member methods / functions
        public void ShowResult()
        {
            if(Marks >=35) {
                Console.WriteLine("Result :Pass "+Marks+"Marks");
            }
            else
            { Console.WriteLine("Result:Fail "+Marks+ "Marks"); }

        }
        // Object class ToString() 
        public override string ToString()
        {
            return "Student Details:  " + Id + " " + Name + " " + Marks + " Date of Admission : " + Doa.ToString();
        }

    }
}
