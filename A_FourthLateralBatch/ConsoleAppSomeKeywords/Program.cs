using System;

namespace ConsoleAppSomeKeywords
{
    internal class Program
    {
        // Keywords params, ref, out, var, dynamic
        static void Main(string[] args)
        {
            //int a=100,b=200;
            //Swap(ref a,ref b);// call by value
            //Console.WriteLine($"a = {a} and b = {b}");
            //int radius = 7;
            //double a;
            //Area(ref radius, out a);
            //Console.WriteLine($"Area of Circle ={a}");
            var x = 10;
            //var name = "Sarita";
            //x = "India";
            //name = 56.90f;
            // var will check and infer data type at compile time and
            // will not allow other data type in the next part of app
            // and it is mandatory to initialize var data 
            // in case of dynamic data type : datatype is decided at run time
            // it is not mandatory to initialize the variable.
            dynamic y;
            y = 10;
            Console.WriteLine($"y = {y}");
            y = 25.90;
            y = Math.PI;
            y = "C# language dynamic data ";
            Console.WriteLine($"y = {y}");
            Console.WriteLine();
            Console.ReadKey();
        }
            
        public static void Area(ref int r,out double A)
        {// A keeps the address of variable a from main function 
            // and stores the o/p directly in location a 
            A = Math.PI * r * r;
        }
        public static void Swap(ref int A, ref int B)
        {
            int c = A;
            A = B;
            B = c;

        }

        public static void GetNames(bool gen, params string[] names) {
            string gender,G;
            if (gen)
            {
                gender = "Mr";
                G = "boys";
            }
            else
            { gender = "Ms";
                G = "girls";
            }
            foreach (string name in names)
            {
                Console.Write($"{gender} {name} ");
            }
            Console.WriteLine($"\nThere are {names.Length}- {G} ");
        }

    }
}
