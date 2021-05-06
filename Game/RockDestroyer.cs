using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class RockDestroyer : Monster, IDestroyer
    {
        public RockDestroyer(Point start, char drawC = 'D', ConsoleColor color = ConsoleColor.Red) : base(start, drawC, color)
        {
        }

        public override void Update()
        {
            base.Update();
        }

        public Point Shoot()
        {
            return new Point(Location.X - 1, Location.Y);
        }
    }
}
