using System;

namespace Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek1 = new Rechthoek();
            rechthoek1.Lengte = 10;
            rechthoek1.Breedte = 15;
            rechthoek1.ToonOppervlakte();

            Rechthoek rechthoek2 = new Rechthoek();
            rechthoek2.Lengte = 25;
            rechthoek2.Breedte = 5;
            rechthoek2.ToonOppervlakte();

            Driehoek driehoek1 = new Driehoek();
            driehoek1.Basis = 5;
            driehoek1.Hoogte = 10;
            driehoek1.ToonOppervlakte();

            Driehoek driehoek2 = new Driehoek();
            driehoek2.Basis = 15;
            driehoek2.Hoogte = 5;
            driehoek2.ToonOppervlakte();
        }
    }
}
