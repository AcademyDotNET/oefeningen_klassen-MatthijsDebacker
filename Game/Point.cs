using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || obj.GetType().BaseType != typeof(Point) && obj.GetType() != typeof(Point))
            {
                return false;
            }

            if(X == ((Point)obj).X && Y == ((Point)obj).Y)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }


        /// <summary>
        /// Returns a point with random X and Y 
        /// within the given min(inclusive)- max(exlcusive) range
        /// </summary>
        public static Point RandomPoint(int min, int max)
        {
            Random rand = new Random();
            return new Point(rand.Next(min, max), rand.Next(min, max));
        }

        /// <summary>
        /// Returns a point with random X and Y 
        /// within the given min(inclusive)- max(exlcusive) range
        /// with seperate ranges for X and Y
        /// </summary>
        public static Point RandomPoint(int minX, int maxX, int minY, int maxY)
        {
            Random rand = new Random();
            return new Point(rand.Next(minX, maxX), rand.Next(minY, maxY));
        }
    }
}
