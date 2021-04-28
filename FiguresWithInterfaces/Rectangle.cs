using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWithInterfaces
{
    class Rectangle : GeometricFigure, IComparable
    {
        public Rectangle(int height, int width) : base(height, width)
        {
        }

        public override int CalculateSurface()
        {
            return Width * Height;
        }

        public int CompareTo(object obj)
        {
            Rectangle rect = (Rectangle)obj;
            if(CalculateSurface() > rect.CalculateSurface())
            {
                return 1;
            }
            else if(CalculateSurface() < rect.CalculateSurface())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Rectangle with Height: {Height} and Width {Width} has a surface of {Surface}";
        }
    }
}
