using System;

namespace PrijzenMetForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = new double[20];

            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = AskForDouble($"{i}: Please enter a price: ");
            }

            Console.WriteLine("All prices higher than 5.00: ");
            double total = 0.0;
            foreach (double price in prices)
            {
                total += price;
                if(price > 5.0)
                {
                    Console.WriteLine(price);
                }
            }

            Console.WriteLine($"The average of all prices is: {total / prices.Length}");
        }

        static double AskForDouble(string question, string errorResponse = "Invalid number, please try again", bool clear = true)
        {
            Console.WriteLine(question);
            double input = 0;

            string sInput = Console.ReadLine();
            while (!double.TryParse(sInput, out input))
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
