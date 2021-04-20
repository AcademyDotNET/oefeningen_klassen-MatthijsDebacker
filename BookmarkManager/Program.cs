using System;

namespace BookmarkManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you five favorite websites.");
            BookMark[] bookMarks = new BookMark[5];

            // FILL ARRAY WITH USER INPUT
            for (int i = 0; i < bookMarks.Length; i++)
            {
                Console.WriteLine($"WEBSITE {i + 1}: ");
                Console.WriteLine(new string('=', 20)); 
                BookMark bm = new BookMark();
                Console.WriteLine("Name: ");
                bm.Name = Console.ReadLine();
                Console.WriteLine("URL: ");
                bm.URL = Console.ReadLine();
                bookMarks[i] = bm;
                Console.Clear();
            }

            // OPEN CHOSEN WEBSITE
            int input = 0;
            do
            {
                // PRINT ARRAY
                for (int i = 0; i < bookMarks.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {bookMarks[i].Name}: {bookMarks[i].URL}");
                }

                Console.WriteLine("Which website do you wish to visit ?");
                input = AskForInt($"1 - {bookMarks.Length}: Select Website / -1: Remove Item / 0: Change Item / 99: End Program");

                // Remove bookmark
                if(input == -1)
                {
                    int index = AskForInt($"1 - {bookMarks.Length}: which bookmark do you wish to remove?");
                    if (index > 0 && index <= bookMarks.Length)
                    {
                        bookMarks[index - 1].Name = "";
                        bookMarks[index - 1].URL = "";
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                }
                // Change bookmark
                else if(input == 0)
                {
                    int index = AskForInt($"1 - {bookMarks.Length}: which bookmark do you wish to change?");
                    if (index > 0 && index <= bookMarks.Length)
                    {
                        Console.WriteLine("Name: ");
                        bookMarks[index - 1].Name = Console.ReadLine();
                        Console.WriteLine("URL: ");
                        bookMarks[index - 1].URL = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                }
                // Open bookmarked website
                else if(input > 0 && input <= bookMarks.Length)
                {
                    bookMarks[input - 1].OpenSite();
                }
            } while (input != 99);
            
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
