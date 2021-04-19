using System;

namespace SportSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            VolleyBallSpeler speler1 = new VolleyBallSpeler("Tom", 2.1, 1);
            VolleyBallSpeler speler2 = new VolleyBallSpeler("Steven", 1.9, 2);

            VolleyBallSpeler.SimuleerSpeler(speler1);
            VolleyBallSpeler.SimuleerWedstrijd(speler1, speler2);
            Console.WriteLine($"{VolleyBallSpeler.BesteSpeler(speler1, speler2).Naam} is de beste speler!");
        }
    }
}
