using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWithInterfaces
{
    abstract class GeometricFigure
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public GeometricFigure(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Surface
        {
            get
            {
                return CalculateSurface();
            }
        }

        public abstract int CalculateSurface();

        public override string ToString()
        {
            return $"{this.GetType()} with Height: {Height} and Width {Width} has a surface of {Surface}";
        }
    }
}
