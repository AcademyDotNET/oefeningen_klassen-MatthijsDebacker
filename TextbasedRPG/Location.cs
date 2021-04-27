using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbasedRPG
{
    class Location
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Exit> Exits { get; set; }
        public List<GameObject> ObjectsInRoom { get; set; }

        public Location()
        {
            Exits = new List<Exit>();
            ObjectsInRoom = new List<GameObject>();
        }

        public Location GetLocationOnMove(Directions direction, List<GameObject> playerInventory)
        {
            foreach (Exit exit in Exits)
            {
                if(exit.ExitDirection == direction)
                {
                    if(exit.TestPassCondition(playerInventory))
                    {
                        return exit.GoesToLocation;
                    }
                    else
                    {
                        Console.WriteLine("You can not leave through this exit (you do not have the required item(s)).");
                        return this;
                    }
                }
            }

            Console.WriteLine("That is not a valid direction.");
            return this;
        }

        public void Describe()
        {
            Console.WriteLine($"{Title}\n*********");
            Console.WriteLine(Description);
            Console.WriteLine("You also see: ");
            foreach (GameObject objects in ObjectsInRoom)
            {
                objects.Describe();
            }
            Console.WriteLine("\n*********");
        }
    }
}
