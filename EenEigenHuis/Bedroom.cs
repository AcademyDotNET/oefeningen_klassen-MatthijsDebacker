using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Bedroom : Room
    {
        public Bedroom(string name, double size) : base(name, size)
        {
        }

        public override double Price
        {
            get
            {
                // Return 400 plus 20 extra per m² above 10;
                return 400.0 + Math.Clamp(Size - 10.0, 0.0, double.MaxValue) * 20.0;
            }
        }

    }
}
