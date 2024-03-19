using System;

namespace myconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            char color = 'R';
            int x = 10;
            float y = 24.98765F;
            double z = 0.00006543;
            decimal price = 100.25m;
            // 1 string format
            Console.WriteLine("color ="+color+" x = "+x+" y ="+y+" z ="+z+" price = "+price);
            //2 Number Well Formated F -> fixed (float) E ->Exponential C->currency
            Console.WriteLine("x ={0} y = {1:f2} z= {2:E2} price ={3:c}",x,y,z,price);
            Console.WriteLine("price = {0}",price);
            //3 String interpolation format
            Console.WriteLine($"x={x} y = {y:f2} z = {z:e2} price = {price:c}");
            Console.ReadKey();
        }
    }
}
