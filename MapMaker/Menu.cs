using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    class Menu
    {
        public Menu()
        { }

        public void ShowMenu()
        {
            //Tekenen
            DrawLine(1);
            DrawOptions(2);
            DrawLine(5);
        }
        private void DrawLine(int hoogte)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, hoogte);
                Console.Write('*');
            }
        }
        private void DrawOptions(int hoogte)
        {
            Console.SetCursorPosition(5, hoogte);
            Console.Write("A) Add a couch at a random position.");
            Console.SetCursorPosition(5, hoogte + 1);
            Console.Write("B) Move the map down.");
            Console.SetCursorPosition(5, hoogte + 2);
            Console.Write("What do you want to do...");
        }
        public void GetInput(List<MapObject> list)
        {
            string input = Console.ReadLine();
            if (input == "A" || input == "a")
            {
                // Add a couch at a random position
                Random rand = new Random();
                list.Add(new CouchElement(new Point(rand.Next(0, 20), rand.Next(6, 20)), 50.0, '+'));
            }
            if (input == "B" || input == "b")
            {
                // Move map down
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Location = new Point(list[i].Location.X, list[i].Location.Y + 1);
                }
            }
        }
    }
}
