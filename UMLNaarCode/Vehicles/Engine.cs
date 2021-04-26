using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLNaarCode.Vehicles
{
    class Engine
    {
        private Piston[] pistons;

        public Piston[] Pistons
        {
            get { return pistons; }
            set 
            {
                if(value.Length >= 4 && value.Length <= 8)
                {
                    pistons = value; 
                }
            }
        }

        public CrankShaft EngineCrankShaft { get; set; }
    }
}
