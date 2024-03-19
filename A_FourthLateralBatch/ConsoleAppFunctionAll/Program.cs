using System;

namespace ConsoleAppFunctionAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Message("India");
            Area(20, 30);
            Area(12.5f, 20.0, 100);
            Area(7.5);
            
            Console.ReadKey();

        }
         public static void Message(string name) {
            Console.WriteLine("Welcome "+name);
        }
        // Overloaded function
        public static void Area(double r)
        {
            double A = Math.PI * r * r;
            Console.WriteLine($"Area of Circle ={A}");
        }

        public static void Area(int l,int b) { 
        
        int A=l*b;
            Console.WriteLine($"Area of Rectangle ={A}");
        }

        public static void Area(float r,double pi,int h) {
         double A= 2*pi*r*h+pi*r*r;
            Console.WriteLine($"surface Area of Cylinder={A}");
        }
        public static void Area(float a,float b )
        {
            Console.WriteLine($"Area ={a+b} ");
        }

       



    }
}
