using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    class Rectangle : GeometricFigure
    {
        public Rectangle(int height, int width) : base(height, width)
        {
        }

        public override int CalculateSurface()
        {
            return Width * Height;
        }
    }
}
