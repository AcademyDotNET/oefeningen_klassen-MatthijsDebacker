using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSimulator
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

        public VolleyBallSpeler(string naam, double lengte, int nummer, int matches = 0, int hoogsteScore = 0, Klasses klasse = Klasses.Vierde)
        {
            Naam = naam;
            Lengte = lengte;
            Nummer = nummer;
            Matches = matches;
            HoogsteScore = HoogsteScore;
            Klasse = klasse;
        }

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

        public static void SimuleerSpeler(VolleyBallSpeler testSpeler)
        {
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                testSpeler.SpeelMatch();
                testSpeler.VerwerkScore(rand.Next(0, 11));
            }
        }

        public static void SimuleerWedstrijd(VolleyBallSpeler speler1, VolleyBallSpeler speler2)
        {
            Random rand = new Random();
            int score = rand.Next(0, 11);
            speler1.VerwerkScore(score);
            score = rand.Next(0, 11);
            speler2.VerwerkScore(score);
            if(speler1.HoogsteScore > speler2.HoogsteScore)
            {
                Console.WriteLine($"{speler1.Naam} (speler1) wint!");
                speler1.SpeelMatch();
                speler1.VerwerkScore(score);
            }
            else
            {
                Console.WriteLine($"{speler2.Naam} (speler2) wint!");
                speler2.SpeelMatch();
                speler2.VerwerkScore(score);
            }
        }

        public static VolleyBallSpeler BesteSpeler(VolleyBallSpeler speler1, VolleyBallSpeler speler2)
        {
            Random rand = new Random();
            speler1.VerwerkScore(rand.Next(0, 11));
            speler2.VerwerkScore(rand.Next(0, 11));

            if(speler1.HoogsteScore > speler2.HoogsteScore)
            {
                return speler1;
            }
            else
            {
                return speler2;
            }
        }
    }
}
