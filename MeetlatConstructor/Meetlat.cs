using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetlatConstructor
{
    class Meetlat
    {
        private double _lengteInMeter;
     
        public Meetlat(double lengte)
        {
            _lengteInMeter = lengte;
        }

        public double LengteInM
        {
            get
            {
                return _lengteInMeter;
            }
        }
        public double LengteInCm 
        {
            get
            {
                return _lengteInMeter * 100.0;
            }
        }
        public double LengteInKm 
        { 
            get
            {
                return _lengteInMeter / 1000.0;
            }
        }
        public double LengteInVoet
        {
            get
            {
                return _lengteInMeter * 3.2808;
            }
        }


    }
}
