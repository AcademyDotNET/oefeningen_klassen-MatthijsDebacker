using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.DataTypes
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x = 1.0, double y = 1.0)
        {
            X = x;
            Y = y;
        }
    }
}
