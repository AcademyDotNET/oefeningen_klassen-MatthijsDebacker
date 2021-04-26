using System;
using System.Collections.Generic;

namespace Politiek
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country();
            country.Name = "SomeCountry";

            President president = new President();
            president.Name = "Somebody Someone";

            List<Minister> ministers = new List<Minister>();
            for (int i = 0; i < 5; i++)
            {
                Minister minister = new Minister();
                minister.Name = $"Minister {i + 1}";
                ministers.Add(minister);
            }

            Console.WriteLine(country);
            country.MakeGovernment(president, ministers);
            Console.WriteLine(country);

            for (int i = 0; i < 6; i++)
            {
                country.AdvanceYear();
            }
        }
    }
}
