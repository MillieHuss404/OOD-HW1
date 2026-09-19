using System;
using System.Collections.Generic;
using System.Text;

namespace OOD_HW1
{
    internal class Square
    {
        //Attributes/Fields
        public double Length;

        //constructor
        //Default Constructor
        public Square()
        {
            Console.WriteLine("New Square instance was created");
            Length = 0;

        }

        //Parameterized Constructor
        public Square(double length)
        {
            Console.WriteLine("New Square instance was created");
            Length = length;
        }

        //copy constructor
        public Square(Square s)
        {
            Console.WriteLine("New Square instance was created");
            Length = s.Length;
        }

        //behavior/methods
        public double CalculateArea()
        {
            return Length*Length;
        }

        public double CalculatePerimeter()
        {
            return Length * 4;
        }
    }
}
