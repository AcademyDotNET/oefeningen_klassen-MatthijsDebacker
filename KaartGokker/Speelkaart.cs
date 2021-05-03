using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaartGokker
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
          return $"{NumberToString(Number)} of {CardSuite}";
        }

        public string NumberToString(int number)
        {
            if (number == 1)
            {
                return "Ace";
            }
            else if (number == 11)
            {
                return "Jack";
            }
            else if (number == 12)
            {
                return "queen";
            }
            else if (number == 13)
            {
                return "King";
            }
            else
            {
                return number.ToString();
            }
        }

        public override string ToString()
        {
            string number = Number.ToString();
            if (Number == 1)
            {
                number = "Ace";
            }
            else if (Number == 11)
            {
                number = "Jack";
            }
            else if (Number == 12)
            {
                number = "Queen";
            }
            else if (Number == 13)
            {
                number = "King";
            }

            return $"{number} of {CardSuite}";
        }

        public override bool Equals(object obj)
        {
            if(obj == null || obj.GetType() != typeof(Speelkaart))
            {
                return false;
            }

            if(Number == ((Speelkaart)obj).Number && CardSuite == ((Speelkaart)obj).CardSuite)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Quick and dirty translation from string to SpeelKaart
        /// Only works if string is of format "number of Suite
        /// </summary>
        public static Speelkaart StringToCard(string str)
        {
            var parts = str.Split(' ');
            if (parts.Length != 3)
            {
                return null;
            }

            if(!Enum.TryParse(parts[2], out Suite suite))
            {
                return null;
            }
            
            int number = 0;
            if(!int.TryParse(parts[0], out number))
            {
                if(parts[0] == "Ace")
                {
                    number = 1;
                }
                else if (parts[0] == "Jack")
                {
                    number = 11;
                }
                else if (parts[0] == "Queen")
                {
                    number = 12;
                }
                else if (parts[0] == "King")
                {
                    number = 13;
                }
                else
                {
                    return null;
                }
            }

            return new Speelkaart(number, suite);
        }
    }
}
