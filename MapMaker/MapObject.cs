using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    interface IComposite
    {
        void UpdateElements(Point offset);
    }

    abstract class MapObject
    {
        private Point location;

        public Point Location
        {
            get { return location; }
            set
            {
                Point prevloc = location;
                Point offset = new Point(1, 1);
                if (location != null)
                {

                    offset.X = value.X - prevloc.X;
                    offset.Y = value.Y - prevloc.Y;
                }

                location = value;
                if (this is IComposite)
                {
                    IComposite obj = this as IComposite;
                    obj.UpdateElements(offset);
                }
            }
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
