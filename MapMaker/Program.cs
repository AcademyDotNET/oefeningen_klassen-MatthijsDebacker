using System;
using System.Collections.Generic;

namespace MapMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MapObject> allObjects = new List<MapObject>();
            Menu menu = new Menu();
            do
            {
                menu.ShowMenu();
                menu.GetInput(allObjects);
                Console.Clear();
                //Teken alle objecten
                for (int i = 0; i < allObjects.Count; i++)
                {
                    allObjects[i].Paint();
                }

                SalonElement salon1 = new SalonElement(new Point(6, 5));
                salon1.Paint();
            } while (true);
        }
    }
}
