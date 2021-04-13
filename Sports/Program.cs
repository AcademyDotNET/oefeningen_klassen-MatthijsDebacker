using System;

namespace Sports
{
    class Program
    {
        static void Main(string[] args)
        {
            VolleyBallSpeler speler1 = new VolleyBallSpeler();
            speler1.StelIn("Erik", 1.80, 1, 5, 2, Klasses.Derde);

            VolleyBallSpeler speler2 = new VolleyBallSpeler();
            speler2.StelIn("Tom", 1.73, 2, 10, 8, Klasses.Tweede);

            VolleyBallSpeler speler3 = new VolleyBallSpeler();
            speler3.StelIn("Sam", 1.65, 3, 1, 1, Klasses.Vierde);

            speler1.SpeelMatch();
            speler2.SpeelMatch();
            speler3.SpeelMatch();

            speler1.Pass(2);
            speler2.Pass(3);
            speler3.Pass(0);

            speler1.VerwerkScore(5);
            speler2.VerwerkScore(1);
            speler3.VerwerkScore(3);
        }
    }
}
