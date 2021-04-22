using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalspelMetOvererving
{
    class PlayerBall : Ball
    {
        public PlayerBall(int xin, int yin, int vxin, int vyin, char drawCharIn = 'X', int sizeIn = 0) : base(xin, yin, vxin, vyin, drawCharIn, sizeIn)
        {
            drawColor = ConsoleColor.Green;
        }

        public void ChangeVelocity(ConsoleKeyInfo richting)
        {
            switch (richting.Key)
            {
                case ConsoleKey.UpArrow:
                    vy--;
                    break;
                case ConsoleKey.DownArrow:
                    vy++;
                    break;
                case ConsoleKey.LeftArrow:
                    vx--;
                    break;
                case ConsoleKey.RightArrow:
                    vx++;
                    break;
                default:
                    break;
            }
        }
    }
}
