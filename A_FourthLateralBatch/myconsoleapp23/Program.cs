using System;

namespace myconsoleapp23
{
    class Program
    {
        static void Main(string[] args)
        {   char color = 'R';
            int x = 10;
            float y = 10.9866555666f;
            double z = 0.00000678;
            decimal price = 25.50m;

            Console.WriteLine("Various data Types Displayed!");
            // string format o/p statement
            Console.Write("color ="+color+" x="+x+ " y = "+y+" z = "+z);
            Console.WriteLine(" price =" + price);
            //number welformatted o/p statement  ( C lang like format)
            Console.WriteLine("x ={0} y ={1:F3} z={2:E2} price = {3:C}",x,y,z,price);
            Console.WriteLine("price ={0}",price);
            //string interpolation format
            Console.WriteLine($"x={x} y ={y:f2} z={z:e2} price ={price:c}" );


            Console.ReadKey();
        }


    }
}
