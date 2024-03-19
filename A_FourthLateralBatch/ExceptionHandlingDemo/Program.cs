using System;

namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y,z;
            try
            {
                Console.WriteLine("Enter a number ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x);
                Console.WriteLine("Enter a number ");
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine(y);
            }

            catch(System.FormatException ex)
            { 
                Console.WriteLine(ex.Message); 
            }
            catch(System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("bye bye program is ending ");
            }
        }
    }
}
