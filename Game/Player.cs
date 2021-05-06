using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player : MapElement, IMoveable, IDestroyer
    {
        private int health;
        public int Health
        {
            get
            {
                return health;
            }
        }

        public ConsoleKey InputKey { get; set; }

        public Player(Point start, char drawC = 'X', ConsoleColor color = ConsoleColor.Blue) : base(start, drawC, color)
        {
            health = 10;
        }

        public void LoseHealth(int amount = 1)
        {
            health -= amount;
        }

        public override void Update()
        {
            Move((Directions)((int)InputKey));
        }

        public void Move(Directions direction, int distance = 1)
        {
            switch (direction)
            {
                case Directions.Up:
                    Location.Y -= distance;
                    break;
                case Directions.Right:
                    Location.X += distance;
                    break;
                case Directions.Down:
                    Location.Y += distance;
                    break;
                case Directions.Left:
                    Location.X -= distance;
                    break;
                default:
                    break;
            }
        }

        public Point Shoot()
        {
            return new Point(Location.X + 1, Location.Y);
        }
    }
}
