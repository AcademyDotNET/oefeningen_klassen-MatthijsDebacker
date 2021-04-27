using System;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.GenerateHand(16);

            Console.WriteLine(manager);
        }
    }
}
