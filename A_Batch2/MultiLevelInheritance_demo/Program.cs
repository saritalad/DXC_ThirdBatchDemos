using System;

namespace MultiLevelInheritance_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Circle c1 = new Circle(10, 1, 1);
            //c1.Area();
            //Cylinder cy1=new Cylinder (100,10, 1, 1);
            //cy1 .Area();

            //Circle C = new Cylinder(120, 10, 1, 10);
            //C.Area();
            //Cylinder cy= new Cylinder(120, 10, 1, 10);
            //cy.Area();
           // Vehicle v= new Vehicle();abstract class can not be instanciated 
           Car mycar= new Car();
            mycar.ShowColor();
            mycar.ShowSpeed();
            mycar.Print();

        }
    }
}
