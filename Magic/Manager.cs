using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    class Manager
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public void AddCard(Card card)
        {
            if(card != null)
            {
                Cards.Add(card);
            }
        }

        public void AddCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Cards.Add(card);
            }
        }

        public void GenerateHand(int number)
        {
            Random rand = new Random();
            Cards.Clear();

            for (int i = 0; i < number; i++)
            {
                int j = rand.Next(0, 4);

                switch (j)
                {
                    case 0:
                        Cards.Add(new AttackCard());
                        break;
                    case 1:
                        Cards.Add(new CreatureCard());
                        break;
                    case 2:
                        Cards.Add(new SpellCard());
                        break;
                    case 3:
                        Cards.Add(new ArtifactCard());
                        break;
                    default:
                        break;
                }
            }
        }

        public override string ToString()
        {
            string str = "";
            if(Cards == null )
            {
                return str;
            }

            foreach (var item in Cards)
            {
                str += $"{item}\n";
            }

            return str;
        }
    }
}
