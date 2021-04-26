using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Kitchen : Room
    {
        public bool BuiltInPantry { get; set; }

        public Kitchen(string name, double size) : base(name, size)
        {
        }

        public override double Price
        {
            get
            {
                if(BuiltInPantry)
                {
                    return 650.0;
                }
                return 400.0;
            }
        }
    }
}
