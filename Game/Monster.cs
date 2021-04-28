using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster : MapElement, IMoveable
    {
        public Monster(Point start, char drawC = 'O') : base(start, drawC)
        {
        }

        public void Move(Direction dir, int dist = 1)
        {
            switch (dir)
            {
                case Direction.Up:
                    NextLocation.Y -= dist;
                    break;
                case Direction.Right:
                    NextLocation.X += dist;
                    break;
                case Direction.Down:
                    NextLocation.Y += dist;
                    break;
                case Direction.Left:
                    NextLocation.X -= dist;
                    break;
                default:
                    break;
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Draw();
            Console.ResetColor();
        }
    }
}
