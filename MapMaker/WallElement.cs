using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    class WallElement : MapObject
    {
        public WallElement()
        {
        }

        public WallElement(Point locationIn, double priceIn, char drawCharIn) : base(locationIn, priceIn, drawCharIn)
        {
        }

        public override void Paint()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }
    }
}
