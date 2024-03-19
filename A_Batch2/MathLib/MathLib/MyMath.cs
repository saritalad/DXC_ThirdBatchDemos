using System;

namespace MathLib
{
    public class MyMath
    {
        public int a { get; set; }
        public int b { get; set; }

        public void Add()
        { Console.WriteLine($"{a}+ {b}={a+b}"); }
        public void Substract()
        { Console.WriteLine($"{a} -  {b}={a - b}"); }

        public void Multiply()
        { Console.WriteLine($"{a} x {b}={a * b}"); }
        public void Divide()
        { Console.WriteLine($"{a} / {b}={a / b}"); }
    }
}
