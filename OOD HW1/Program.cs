using System;
using System.Collections.Generic;
using System.Text;

namespace OOD_HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square();
            square1.Length = 12;

            Square square2 = new Square(20);

            Triangle triangle1 = new Triangle();
            triangle1.Base = 6;
            triangle1.Height = 8;
            triangle1.Side1 = 8;
            triangle1.Side2 = 10;

            Triangle triangle2 = new Triangle(12, 10, 15, 9);


        }
    }
}
