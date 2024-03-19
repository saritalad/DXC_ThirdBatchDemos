using System;

namespace ConsoleAppInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name;
            //Console.WriteLine("Please enter your name");
            //name= Console.ReadLine();//Input statement
            //Console.WriteLine("Hello!" + name);
            //int x;
            //Console.WriteLine("enter a number ");
            //x=Convert.ToInt32(Console.ReadLine());// "10" = 10
            //int y;
            //Console.WriteLine("enter a number ");
            //y = Convert.ToInt32(Console.ReadLine());
            //int z = x + y;
            //Console.WriteLine($"{x}+ {y} = {z}");
            int qty;
            decimal price, amount;
            string product;
            Console.WriteLine("enter product name to buy");
            product = Console.ReadLine();
            Console.WriteLine("what is the price of it?");
            price= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How much quantity did you buy?");
            qty =   Convert.ToInt32(Console.ReadLine());
            amount=price*qty;
            Console.WriteLine($"Product{product} bought at price {price} cost me {amount:c}");
            Console.ReadKey();
        }
    }
}
