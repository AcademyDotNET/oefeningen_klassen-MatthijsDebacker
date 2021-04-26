using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Hallway : Room
    {
        public Hallway(string name, double size) : base(name, size)
        {
        }

        public override double Price
        {
            get
            {
                return 10 * Size;
            }
        }
    }
}
