using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    class Rechthoek
    {

        private int _lengte = 1;
        private int _breedte = 1;

        public int Lengte
        {
            get 
            {
                return _lengte; 
            }
            set 
            {
                if(value >= 1)
                { 
                    _lengte = value; 
                }
            }
        }


        public int Breedte
        {
            get 
            { 
                return _breedte;
            }
            set 
            { 
                if(value >= 1)
                {
                    _breedte = value;
                }
            }
        }

        public void ToonOppervlakte()
        {
            Console.WriteLine($"Oppervlakte: {_breedte * _lengte}");
        }

    }
}
