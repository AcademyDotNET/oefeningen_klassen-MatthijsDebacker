using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    class Square : Rectangle
    {
        public Square(int height, int width) : base(height, width)
        {
            if(Width != Height)
            {
                Width = Height;
            }
        }

        public Square(int size) : base(size, size)
        {
        }

        public override int CalculateSurface()
        {
            return base.CalculateSurface();
        }
    }
}
