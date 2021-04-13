using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports
{
    class VolleyBallSpeler
    {
        private string _naam;

        public string Naam
        {
            get 
            { 
                return _naam;
            }
            set 
            { 
                if(value != "")
                {
                   _naam = value; 
                }
            }
        }

        private double _hoogte;

        public double Hoogte
        {
            get 
            {
                return _hoogte; 
            }
            set 
            {
                if(value > 0.0)
                {
                    _hoogte = value; 
                }
            }
        }

        private int _nummer;

        public int Nummer
        {
            get 
            {
                return _nummer; 
            }
            set 
            {
                if(value > 0 && value < 7)
                {
                    _nummer = value; 
                }
            }
        }

        private int _matches;

        public int Matches
        {
            get 
            {
                return _matches; 
            }
            set 
            {
                if(value >= 0)
                {
                    _matches = value; 
                }
            }
        }

        private int _hoogsteScore;

        public int HoogsteScore
        {
            get 
            { 
                return _hoogsteScore;
            }
            set 
            {
                if(value >= 0)
                {
                    _hoogsteScore = value; 
                }
            }
        }
            

        public void StelIn(string naam, double hoogte, int nummer, int matches, int hoogste)
        {
            _naam = naam;
            _hoogte = hoogte;
            _nummer = nummer;
            _matches = matches;
            _hoogsteScore = hoogste;
        }

    }
}
