using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    class Driehoek
    {
        private int _hoogte = 1;
        private int _basis = 1;

        public int Hoogte
        {
            get 
            { 
                return _hoogte; 
            }
            set 
            { 
                if(value >= 1)
                {
                    _hoogte = value;
                }
            }
        }


        public int Basis
        {
            get 
            { 
                return _basis; 
            }
            set 
            { 
                if(value >= 1)
                {
                    _basis = value; 
                }
            }
        }

        public void ToonOppervlakte()
        {
            Console.WriteLine($"Oppervlakte: {0.5 * _basis * _hoogte}");
        }
    }
}
