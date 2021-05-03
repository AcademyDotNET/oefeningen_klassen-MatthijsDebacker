using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Rock : MapElement
    {
        public Rock(Point start, char drawC = 'O', ConsoleColor color = ConsoleColor.White) : base(start, drawC, color)
        {
        }
    }
}
