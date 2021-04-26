using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class Country
    {
        private President president;
        private Minister firstMinister;
        private List<Minister> ministers = new List<Minister>();
        public string Name { get; set; }

        public void MakeGovernment(President pres, List<Minister> mins)
        {
            if(president != null)
            {
                Console.Write("Cannot create a new government. There is already a government in place.");
                return;
            }

            if (mins.Count > 0 && mins.Count <= 5)
            {
                president = pres;
                ministers = new List<Minister>();
                firstMinister = mins[0];
                for (int i = 1; i < 5; i++)
                {
                    if(i < mins.Count)
                    {
                        ministers.Add(mins[i]);
                    }
                    else
                    {
                        ministers.Add(null);
                    }
                }
            }
        }

        public void AdvanceYear()
        {
            if(president == null)
            {
                Console.WriteLine("Cannot advance a year as there is no government in place.");
                return;
            }

            president.AdvanceYear();
            if(president.Year <= 0)
            {
                president = null;
                firstMinister = null;
                ministers = new List<Minister>();
                for (int i = 0; i < 4; i++)
                {
                    ministers.Add(null);
                }
                Console.WriteLine("This Government's term has ended.");
            }
        }

        public override string ToString()
        {
            if(president == null)
            {
                return $"{Name} has no government.";
            }
            return $"{Name}: Our government consists of president {president.Name} and prime minister {firstMinister.Name}.\nThere are {ministers.Count} other ministers.";
        }
    }
}
