using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports
{
    public enum Klasses
    {
        Eerste,
        Tweede,
        Derde,
        Vierde
    }

    class VolleyBallSpeler
    {
        private string _naam = "Speler";

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

        private double _lengte = 1.7;

        public double Lengte
        {
            get 
            {
                return _lengte; 
            }
            set 
            {
                if(value > 0.0)
                {
                    _lengte = value; 
                }
            }
        }

        private int _nummer = 1;

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

        private int _matches = 0;

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

        private int _hoogsteScore = 0;

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

        private Klasses _klasse;

        public Klasses Klasse
        {
            get 
            { 
                return _klasse; 
            }
            set 
            { 
                _klasse = value; 
            }
        }



        public void StelIn(string naam, double hoogte, int nummer, int matches, int hoogste, Klasses klasse)
        {
            Naam = naam;
            Lengte = hoogte;
            Nummer = nummer;
            Matches = matches;
            HoogsteScore = hoogste;
            Klasse = klasse;
        }

        public void SpeelMatch()
        {
            _matches++;
            Console.WriteLine($"Speler {Nummer} begint aan de match. Nieuw totaal: {Matches}.");
        }

        public void Pass(int speler)
        {
            if(speler > 0 && speler < 7)
            {
                Console.WriteLine($"Speler {Nummer} maakt een pass naar speler {speler}.");
            }
            else
            {
                Console.WriteLine($"Speler {Nummer} maakt een pass, niemand vangt de bal op.");
            }
        }

        public void VerwerkScore(int score)
        {
            if(score > HoogsteScore)
            {
                HoogsteScore = score;
            }
            Console.WriteLine($"Speler {Nummer} scoorde {score} punten in deze match. Hun hoogste score is {HoogsteScore}.");
        }
    }
}
