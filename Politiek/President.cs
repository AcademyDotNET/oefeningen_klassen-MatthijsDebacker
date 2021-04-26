using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class President : Minister
    {
        public int Year { get; private set; } = 4;

        public void AdvanceYear()
        {
            Year--;
        }

        public override string ToString()
        {
            return $"President: {Name}";
        }
    }
}
