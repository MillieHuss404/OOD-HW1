using System;
using System.Collections.Generic;
using System.Text;

namespace OOD_HW1
{
    internal class Triangle
    {
        //Attributes/Fields
        public double Base;
        public double Height;
        public double Side1;
        public double Side2;


        //constructor
        //Default Constructor
        public Triangle()
        {
            Console.WriteLine("New Triangle instance was created");
            Base = 0;
            Height = 0;
            Side1 = 0;
            Side2 = 0;

        }

        //Parameterized Constructor
        public Triangle(double base1, double height, double side1, double side2)
        {
            Console.WriteLine("New Triangle instance was created");
            Base = base1;
            Height = height;
            Side1 = side1;
            Side2 = side2;
        }

        //copy constructor
        public Triangle(Triangle t)
        {
            Console.WriteLine("New Square instance was created");
            Base = t.Base;
            Height = t.Height;
            Side1 = t.Side1;
            Side2 = t.Side2;
        }

        //behavior/methods
        public double CalculateArea()
        {
            return (Base * Height) / 2;
        }

        public double CalculatePerimeter()
        {
            return Base + Side1 + Side2;
        }
    }
}
