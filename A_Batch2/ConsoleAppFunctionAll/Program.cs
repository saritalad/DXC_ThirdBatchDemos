using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppFunctionAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Message("India");
            //Console.WriteLine("End of Program");
            // int x = 100, y = 200;
            //int m= Max(x, y);
            // Console.WriteLine(" Maximum number is "+m);

            Sum(10.5f, 10);
            Sum(10, 20);
            Sum(20, 30,40);
            Sum(10, 25.5f);
            Sum(10, 24);

        }

        // 2 or multiple functions having different signature but same name are
        // called overloaded functions
        // signature comprise of datatype of paramters 
        //                       number of paramters
        //                       sequence of parameters
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b}= {a+b}");
        }
        public static void Sum(int a, int b,int c)
        {
            Console.WriteLine($"{a} + {b}+{c}= {a + b + c}");
        }

        public static void Sum(float a, int b)
        {
            Console.WriteLine($"{a} + {b}= {a + b}");
        }
        public static void Sum(int a, float b)
        {
            Console.WriteLine($"{a} + {b}= {a + b}");
        }

        //     public static void Message(string name) 
        //    {
        //        Console.WriteLine($"Welcome {name}");
        //    }

        //    public static int Max(int a,int b)
        //    {
        //        if(a > b)
        //        {
        //            return a;
        //        }
        //        else
        //            return b;
        //    }

    }
}
