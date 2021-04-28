using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player : MapElement, IMoveable, IDestroyer
    {
        public Player(Point start, char drawC = 'O') : base(start, drawC)
        {
        }

        public void Move(Direction dir, int dist = 1)
        {
            lastLocation.X = Location.X;
            lastLocation.Y = Location.Y;

            switch (dir)
            {
                case Direction.Up:
                    Location.Y -= dist;
                    break;
                case Direction.Right:
                    Location.X += dist;
                    break;
                case Direction.Down:
                    Location.Y += dist;
                    break;
                case Direction.Left:
                    Location.X -= dist;
                    break;
                default:
                    break;
            }
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            if(Console.KeyAvailable)
            {
                Move((Direction)((int)Console.ReadKey().Key));
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Draw();
            Console.ResetColor();
        }
    }
}
