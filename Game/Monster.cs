using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster : MapElement, IMoveable
    {
        public Monster(Point start, char drawC = 'M', ConsoleColor color = ConsoleColor.Red) : base(start, drawC, color)
        {
        }

        public override void Update()
        {
            Move(Directions.Random);
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
                case Directions.Random:
                    Random rand = new Random();
                    if(rand.Next(0, 2) == 0)
                    {
                        if(rand.Next(0, 2) == 0)
                        {
                            Location.X += distance;
                        }
                        else
                        {
                            Location.X -= distance;
                        }
                    }
                    else
                    {
                        if (rand.Next(0, 2) == 0)
                        {
                            Location.Y += distance;
                        }
                        else
                        {
                            Location.Y -= distance;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
