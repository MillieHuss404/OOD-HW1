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

            Console.WriteLine($"Length of Square 1 of is {square1.Length}.");
            Console.WriteLine($"Perimeter is {square1.CalculatePerimeter()}");
            Console.WriteLine($"Area is {square1.CalculateArea()}");

            Square square2 = new Square(20);

            Console.WriteLine($"Length of Square 2 of is {square2.Length}.");
            Console.WriteLine($"Perimeter is {square2.CalculatePerimeter()}");
            Console.WriteLine($"Area is {square2.CalculateArea()}");

            Triangle triangle1 = new Triangle();
            triangle1.Base = 6;
            triangle1.Height = 8;
            triangle1.Side1 = 8;
            triangle1.Side2 = 10;

            Console.WriteLine($"Base of Triangle 1 is {triangle1.Base}. Height is {triangle1.Height}. Side 1 is {triangle1.Side1}. Side 2 is {triangle1.Side2}");
            Console.WriteLine($"Perimeter is {triangle1.CalculatePerimeter()}");
            Console.WriteLine($"Area is {triangle1.CalculateArea()}");

            Triangle triangle2 = new Triangle(12, 10, 15, 9);

            Console.WriteLine($"Base of Triangle 2 is {triangle2.Base}. Height is {triangle2.Height}. Side 1 is {triangle2.Side1}. Side 2 is {triangle2.Side2}");
            Console.WriteLine($"Perimeter is {triangle2.CalculatePerimeter()}");
            Console.WriteLine($"Area is {triangle2.CalculateArea()}");


        }
    }
}
