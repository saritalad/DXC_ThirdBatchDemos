using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionS_Demo
{
    internal class Student:IComparable
    {
        public int Id {get; set; }
        public string Name { get; set; }

        //public int CompareTo(object obj)
        //{
        //    Student student = obj as Student;
        //    if(this.Id<student.Id)
        //        return -1;
        //    else
        //        if(this.Id>student.Id)
        //        return 1;
        //    else
        //        return 0;
        //}
        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            return string.Compare(this.Name, student.Name);
        }




        public override string ToString()
        {
            return "Id :"+Id +" Name: "+Name;
        }
    }
}
