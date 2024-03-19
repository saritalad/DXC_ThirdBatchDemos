using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance_demo
{
    internal class Circle:Point
    {
        public int Radius { get; set; }

        public Circle(int radius,int x,int y):base(x,y)
        {
            Radius = radius;
        }

        public virtual void Area()
        {
            double a = Math.PI * Radius * Radius;
            Console.WriteLine($"Area of Circle {a}");
        }

    }
}
