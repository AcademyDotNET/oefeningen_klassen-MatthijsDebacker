using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speelkaarten
{
    public enum Suite
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    class Speelkaart
    {
        public Speelkaart(int number, Suite suite)
        {
            Number = number;
            CardSuite = suite;
        }

        public int Number { get; set; }
        public Suite CardSuite { get; set; }
        
        public string CardToString()
        {
            string number = Number.ToString();
            if(Number == 1)
            {
                number = "Ace";
            }
            else if(Number == 11)
            {
                number = "Jack";
            }
            else if(Number == 12)
            {
                number = "queen";
            }
            else if(Number == 13)
            {
                number = "King";
            }

          return $"{number} of {CardSuite}";
        }
    }
}
