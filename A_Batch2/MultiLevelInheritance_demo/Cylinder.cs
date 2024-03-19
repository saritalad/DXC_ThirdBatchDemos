using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance_demo
{
    internal class Cylinder:Circle
    {
        public int Height {  get; set; }
        public Cylinder(int height,int radius,int x,int y):base(radius,x,y)
        {
            Height = height;
        }
        // new formula will go in shadow and old Area() will work 
        // if ref of circle has address of cylinder obj
        // this effect is called shadowing effect
        public new void Area()
        {
           double a= 2*Math.PI*Radius*Height+2*Math.PI*Radius*Radius;
            Console.WriteLine($"Surface Area of Cylinder :{a}");
        }
    }
}
