using System;
using System.Collections.Generic;
using System.Linq;

//  2) Herbekijk de kaartspel oefening.Hierbij hebben we dus 52 kaarten.
//  maak nu een random kaartschudder die onze kaarten in willekeurige volgorde in een stack gaat stoppen. Je trekt dan de bovenste kaart en toont deze op het scherm.
//  PT2: Zorg dat we er een 'spel'  van kunnen maken; de gebruiker moet de kaart kunnen gokken.

namespace KaartGokker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Speelkaart> cards = new List<Speelkaart>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add(new Speelkaart(j, (Suite)i));
                }
            }

            Stack<Speelkaart> shuffledCards = ShuffleCards(cards);
            //foreach (var item in shuffledCards)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine("Think of a card.");
            //foreach (Speelkaart card in shuffledCards)
            //{
            //    Console.WriteLine("Is this your card?");
            //    Console.WriteLine(card.ToString());
            //    Console.ReadLine();
            //}

            //Console.WriteLine("No more cards.");

            // Part 2
            string input = "";
            Speelkaart inputCard;
            do
            {
                Console.WriteLine("Guess the next card: (\"number\" of \"Card Type\")");
                Console.WriteLine($"CHEAT| {shuffledCards.Peek()} |CHEAT");

                input = Console.ReadLine();
                inputCard = Speelkaart.StringToCard(input);

                if (Speelkaart.StringToCard(input).Equals(shuffledCards.Peek()))
                {
                    Console.Clear();
                    Console.WriteLine($"Correct! It was indeed: {shuffledCards.Peek()}.\nTry again...");
                    shuffledCards.Pop();
                }
                else
                {
                    Console.WriteLine("Wrong! Try again.");
                }

            } while (shuffledCards.Count > 0);

        }

        public static Stack<Speelkaart> ShuffleCards(List<Speelkaart> cards)
        {
            Random rand = new Random();
            //return new Stack<Speelkaart>(cards.OrderBy(x => rand.Next()));
            
            Stack<Speelkaart> shuffledCards = new Stack<Speelkaart>();

             while (cards.Count > 0)
            {
                int index = rand.Next(0, cards.Count );
                shuffledCards.Push(cards[index]);
                cards.RemoveAt(index);
            }
            return shuffledCards;
        }
    }
}
