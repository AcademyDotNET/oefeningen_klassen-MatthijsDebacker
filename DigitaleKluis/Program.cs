using System;

namespace DigitaleKluis
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitaleKluis kluis1 = new DigitaleKluis(515);
            DigitaleKluis kluis2 = new DigitaleKluis(16834);
            DigitaleKluis kluis3 = new DigitaleKluis(13673);
            DigitaleKluis kluis4 = new DigitaleKluis(211683);

            kluis1.CanShowCode = false;
            kluis4.CanShowCode = false;

            Console.WriteLine();
            Console.WriteLine($"Kluis 1 code level: {kluis1.CodeLevel}.");
            Console.WriteLine($"Kluis 2 code level: {kluis2.CodeLevel}.");
            Console.WriteLine($"Kluis 3 code level: {kluis3.CodeLevel}.");
            Console.WriteLine($"Kluis 4 code level: {kluis4.CodeLevel}.");

            Console.WriteLine();

            Console.WriteLine($"Kluis 1 code: {kluis1.Code}.");
            Console.WriteLine($"Kluis 2 code: {kluis2.Code}.");
            Console.WriteLine($"Kluis 3 code: {kluis3.Code}.");
            Console.WriteLine($"Kluis 4 code: {kluis4.Code}.");
            Console.WriteLine();

            int kluis = 0;
            DigitaleKluis current = null;
            do
            {
                kluis = AskForInt("Voor welke kluis wilt u de code raden?");
                switch (kluis)
                {
                    case 1:
                        current = kluis1;
                        break;
                    case 2:
                        current = kluis2;
                        break;
                    case 3:
                        current = kluis3;
                        break;
                    case 4:
                        current = kluis4;
                        break;
                    default:
                        break;
                }

            } while (current == null);

            int input = 0;
            do
            {
                input = AskForInt($"Raad de code voor kluis {kluis}: ");
                current.TryCode(input);
            }while (input != current.Code) ;
        }

        static int AskForInt(string question, string errorResponse = "Invalid number, please try again", bool clear = false)
        {
            Console.WriteLine(question);
            int input = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out input))
            {
                if (clear)
                {
                    Console.Clear();
                }
                Console.WriteLine(errorResponse);
                sInput = Console.ReadLine();
            }

            return input;
        }
    }
}
