using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLNaarCode.Vehicles
{
    class Boat
    {
        private Propellor[] propellors;

        public Propellor[] Propellors
        {
            get { return propellors; }
            set 
            { 
                if(value.Length >= 1 && value.Length <= 4)
                {
                    propellors = value; 
                }
            }
        }

        public Engine BoatEngine { get; set; }
    }
}
