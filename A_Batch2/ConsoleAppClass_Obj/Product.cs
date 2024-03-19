using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass_Obj
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private static int Count {  get; set; }
        // Static constructor is private
        static Product() {
            Count = 100;
           // Console.WriteLine("This is a Static Constructor");
        }
        public Product(string name, string description)
        {
            Name = name;    
            Description = description;
            Count++;
        }
        public static void DisplayCount()
        {
            Console.WriteLine($" Count Value {Product.Count} ");
        }
    }
}
