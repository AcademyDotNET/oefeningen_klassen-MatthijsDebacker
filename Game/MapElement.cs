using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class MapElement
    {
        protected char drawChar;

        public Point Location { get; set; }
        protected Point lastLocation { get; set; }

        public MapElement(Point start, char drawC = 'O')
        {
            Location = start;
            lastLocation = new Point();
            drawChar = drawC;
        }

        public virtual void Update()
        {
        }

        public virtual void Draw()
        {
            if (!Location.Equals(lastLocation))
            {
                Console.SetCursorPosition(lastLocation.X, lastLocation.Y);
                Console.Write(' ');
                Console.SetCursorPosition(Location.X, Location.Y);
                Console.Write(drawChar);
                lastLocation.X = Location.X;
                lastLocation.Y = Location.Y;
            }
        }
    }
}
