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

        public void Move(Directions direction, int distance = 1)
        {
        }
    }
}
