using System;
using System.Collections.Generic;

namespace Speelkaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Speelkaart> Cards = new List<Speelkaart>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Cards.Add(new Speelkaart(j, (Suite)i));
                }
            }

            Random rand = new Random();
            Console.WriteLine("Pick a card. (Doesn't matter)");

            while(Cards.Count > 0)
            {
                int index = rand.Next(0, Cards.Count);
                Speelkaart card = Cards[index];
                Console.WriteLine($"Is this your card? {card.CardToString()}    (Again, doesn't matter)");
                Console.ReadLine();
                Cards.RemoveAt(index);
            }
        }
    }
}
