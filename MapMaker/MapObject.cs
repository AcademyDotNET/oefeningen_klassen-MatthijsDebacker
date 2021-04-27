using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    abstract class MapObject
    {
        private Point location;

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private char drawChar;

        public char DrawChar
        {
            get { return drawChar; }
            set { drawChar = value; }
        }

        public MapObject()
        {
            Location = new Point(1, 1);
            Price = 1.0;
            DrawChar = '0';
        }

        public MapObject(Point locationIn, double priceIn, char drawCharIn)
        {
            Location = locationIn;
            Price = priceIn;
            DrawChar = drawCharIn;
        }

        // Teken object in de console
        public abstract void Paint();
    }
}
