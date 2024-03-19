using System;

namespace ConsoleAppInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sarita";
            //Console.WriteLine("Please enter your name ");
            //name = Console.ReadLine();// press cntrol KC for comment 
            //// to uncomment press ctrl ku
            //Console.WriteLine("welcome " + name);
            //int x,y,z;
            //Console.WriteLine("Enter a number "  );
            //x =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a number ");
            //y = Convert.ToInt32(Console.ReadLine());
            //z = x + y;
            //Console.WriteLine($" {x} + {y} = {z} ");
            int qty;
            decimal price, amount;
            string product;
            Console.WriteLine("enter product name ");
            product= Console.ReadLine();
            price= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("how much quantity do you buy?");
            qty=Convert.ToInt32(Console.ReadLine()) ;
            amount=price*qty;
            Console.WriteLine($" I bought {product} with {price} amount is  {amount}");
            Console.ReadKey();
        }
    }
}
