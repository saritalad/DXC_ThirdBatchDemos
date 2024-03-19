using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance_demo
{
    internal abstract class Vehicle
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Speed {  get; set; }
        public abstract void ShowSpeed();

        public void ShowColor()
        {
            Console.WriteLine($"Color of Vehicle : {Color}");
        }
    }
}
