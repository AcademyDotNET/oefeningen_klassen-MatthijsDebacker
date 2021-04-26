using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Bathroom : Room
    {
        public Bathroom(string name, double size) : base(name, size)
        {
        }

        public override double Price 
        {
            get
            {
                return 500.0;
            } 
        }
    }
}
