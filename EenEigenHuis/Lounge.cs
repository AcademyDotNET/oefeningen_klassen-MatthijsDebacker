using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Lounge : Room
    {
        public bool Chimney { get; set; }

        public Lounge(string name, double size) : base(name, size)
        {
        }

        public override double Price
        {
            get
            {
                if(Chimney)
                {
                    return 500.0;
                }
                return 300;
            }
        }

    }
}
