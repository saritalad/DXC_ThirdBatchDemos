using System;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array is a block of memory to store homogeneous data
            string[] fruits = { "Mango", "Grapes", "Orange", "Apple", "Banana" };
            for (int i = 0; i < fruits.Length; i++)
                Console.WriteLine(fruits[i]);
            Console.WriteLine(".....foreach loop.........");
            foreach (string f in fruits)
                Console.WriteLine(f);
            Array.Sort(fruits);
            Console.WriteLine("....Sorted Array is ............");
            foreach (string f in fruits)
                Console.WriteLine(f);
            Console.WriteLine("..... Array in Descending order......");
            Array.Reverse(fruits);
            foreach (string f in fruits)
                Console.WriteLine(f);
        }
    }

}
