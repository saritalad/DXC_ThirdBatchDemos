using System;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array
            string[] fruits = { "Apple", "Banana", "Orange", "Mango", "Grapes" };
            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}
            Console.WriteLine(" ............. foreach Loop ..............");
            foreach (string f in fruits)
            {
                Console.WriteLine(f);
            }
            Array.Sort(fruits);
            Console.WriteLine("........sorted Array is ......");
            foreach (string f in fruits)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine(".......Array in Descending Order ...........");
            Array.Reverse(fruits);
            foreach (string f in fruits)
            {
                Console.WriteLine(f);
            }


            try
            {
                int x = 10, y = 0;
                int z = x / y;
                Console.WriteLine(z);
            }
            //unhandled exception
            finally { Console.WriteLine("bye"); }
            Console.ReadKey();

        }
    }
}
