
using System;

namespace ConsoleAppKeywords
{
    internal class Program
    {// ref , out, var, dynamic 
        static void Main(string[] args)
        {
            //GetNames(true, "Bill", "Mill", "Jill", "Nill");
            //GetNames(false, "Seema", "Rita", "Chandana", "Smita", "Gita");
            //int x = 100, y = 200;
            //Swap(ref x,ref y);// call by ref function
            //Console.WriteLine($" x = {x} and y ={y}");
            //int radius = 3;
            //double A;
            //Area(ref radius,out A);
            //Console.WriteLine($"Area of Circle ={A}");
            var x = 10;// implicit datatype declared : decided at compile time
                       // x = "India";
            var y = "USA";
            y = "India";
            Console.WriteLine(  y);
            // y = 12;
            dynamic name = "Sarita";// data type is decided at run time 
            name = 200;
            Console.WriteLine(name);

        }

        public static void Area(ref int r, out double a)
        {
            a = Math.PI * r * r;

        }
          public static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y= temp;

        }
      



        public static void GetNames(bool gen,params string[] names)
        {
            string gender, g;
            if (gen)
            { g = "Mr"; gender = "boys"; }
            else
            { g = "Ms"; gender = "girls"; }
            foreach (string name in names)
            {
                Console.Write($"{g} {name} ");
            }

            Console.WriteLine($"\nThere are total {names.Length} {gender}");
        }



    }
}
