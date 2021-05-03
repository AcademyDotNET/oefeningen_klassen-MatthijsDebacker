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
        protected Point lastLocation;
        public ConsoleColor Color { get; set; }

        public MapElement(Point start, char drawC = 'O', ConsoleColor color = ConsoleColor.White)
        {
            Location = start;
            lastLocation = new Point();
            drawChar = drawC;
            Color = color;
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            if (!lastLocation.Equals(Location))
            {
                Console.ForegroundColor = Color;
                Console.SetCursorPosition(lastLocation.X, lastLocation.Y);
                Console.Write(' ');
                Console.SetCursorPosition(Location.X, Location.Y);
                Console.Write(drawChar);
                Console.ForegroundColor = Color;
                lastLocation.X = Location.X;
                lastLocation.Y = Location.Y;
            }
        }

        public static bool Collision(MapElement element1, MapElement element2)
        {
            if (element1.Location.Equals(element2.Location) || element1.Location.Equals(element2.Location))
            {
                // If player hit a monster or rock destroyer: lose health
                if (element1.GetType() == typeof(Player) && (element2.GetType() == typeof(Monster) || element2.GetType() == typeof(RockDestroyer)))
                {
                    ((Player)element1).LoseHealth();
                }
                element1.SetBack();
                return true;
            }
            return false;
        }

        public virtual void SetBack()
        {
            Location.X = lastLocation.X;
            Location.Y = lastLocation.Y;
        }
    }
}
