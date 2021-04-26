using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLNaarCode.Vehicles
{
    class Car
    {
        private Wheel[] wheels;

        public Wheel[] Wheels
        {
            get { return wheels; }
            set 
            {
                if(value.Length == 4)
                {
                    wheels = value; 
                }
            }
        }

        public Engine CarEngine { get; set; }
    }
}
