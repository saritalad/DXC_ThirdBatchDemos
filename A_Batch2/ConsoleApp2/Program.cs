using System;
using MathLib;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath obj = new MyMath() { a = 100, b = 20, };
            obj.Add();
            obj.Substract();
            obj.Multiply();
            obj.Divide();
        }
    }
}
