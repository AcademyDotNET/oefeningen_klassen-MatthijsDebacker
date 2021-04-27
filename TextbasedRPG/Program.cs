using System;

namespace TextbasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to AP adventure. An adventure for brave and not so brave students. Are You Ready?");

            GameManager theGame = new GameManager();

            // Start the gameloop
            while (!theGame.Exit)
            {
                // Describe the room
                theGame.DescribeLocation();
                // Show actions
                theGame.ShowActions();
                // Read out the action
                theGame.ProcessAction();

            }
        }
    }
}
