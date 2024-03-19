using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance_demo
{
    internal class Car:Vehicle,IPrintable
    {
        public Car() {
            Brand = "Maruti";
            Model = "Swift";
            Color = "Blue";
            Speed = 100;
             }

        public void Method1()
        {
            throw new NotImplementedException();
        }

        public void Method2()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Brand " + Brand + "Model"+Model+"Color :"+Color);
        }

        public override void ShowSpeed()
        {
            Console.WriteLine($" This Car has Average Speed {Speed}");
        }
    }
}
