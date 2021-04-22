using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis
{
    class InsuredPatient : Patient
    {
        public InsuredPatient(string name, int hours) : base(name, hours)
        {

        }

        public override double CalculateCost()
        {
            return (50 + 200 * Hours) * 0.9;
        }
    }
}
