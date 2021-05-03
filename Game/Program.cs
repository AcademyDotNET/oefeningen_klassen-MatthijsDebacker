using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Point margin = new Point(5, 5);
            int gameWidth = 20;
            int gameHeight = 20;
            GameManager manager = new GameManager(margin, gameWidth, gameHeight);

            ConsoleKeyInfo input = new ConsoleKeyInfo();
            do
            {
                manager.Update(input.Key);
                manager.Draw();

                Console.SetCursorPosition(0, margin.Y + gameHeight + 1);
                Console.WriteLine(new string('=', margin.X + gameWidth * 2));
                do
                {
                    input = Console.ReadKey();

                } while (!CheckInput(input.Key));
            } while (!manager.GameWon);
        }

        public static bool CheckInput(ConsoleKey key)
        {
            if (key == ConsoleKey.S 
                || key == ConsoleKey.UpArrow
                || key == ConsoleKey.RightArrow
                || key == ConsoleKey.DownArrow
                || key == ConsoleKey.LeftArrow)
            {
                return true;
            }

            return false;
        }
    }
}
