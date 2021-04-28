using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MapElement> elements = new List<MapElement>();
            GameManager manager = new GameManager();

            do
            {
                manager.Update();
                manager.Draw();
                System.Threading.Thread.Sleep(50);
            } while (true);
        }
    }
}
