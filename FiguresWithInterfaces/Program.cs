using System;
using System.Collections.Generic;

namespace FiguresWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();

            Random rand = new Random();

            Console.WriteLine("Unordered: ");
            Console.WriteLine(new string('=', 20));

            // Fill List with randomized rectangles
            for (int i = 0; i < 10; i++)
            {
                Rectangle rect = new Rectangle(rand.Next(1, 11), rand.Next(1, 10));
                rectangles.Add(rect);
                // Show unordered list first
                Console.WriteLine(rect);
            }

            Console.WriteLine();
            Console.WriteLine("Ordered: ");
            Console.WriteLine(new string('=', 20));

            // Sort and then show the ordered list
            rectangles.Sort();
            foreach (Rectangle rect in rectangles)
            {
                Console.WriteLine(rect);
            }
        }
    }
}
