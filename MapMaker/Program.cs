using System;
using System.Collections.Generic;

namespace MapMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MapObject> allObjects = new List<MapObject>();
            SalonElement salon1 = new SalonElement(new Point(6, 5));
            allObjects.Add(salon1);
            
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

            } while (true);
        }
    }
}
