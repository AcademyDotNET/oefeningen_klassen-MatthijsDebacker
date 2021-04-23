using System;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 2);
            Square square1 = new Square(10);
            Square square2 = new Square(8,8);
            Square square3 = new Square(5,6);
            Triangle triangle = new Triangle(6, 3);

            Console.WriteLine(rect);
            Console.WriteLine(square1);
            Console.WriteLine(square2);
            Console.WriteLine(square3);
            Console.WriteLine(triangle);
        }
    }
}
