using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbasedRPG
{
    class GameManager
    {
        private Location currentLocation = null;
        public bool Exit { get; set; }

        public GameManager()
        {
            InitGame();
        }

        public void DescribeLocation()
        {
            this.currentLocation.Describe();
        }

        public void ProcessAction()
        {
            string actie = Console.ReadLine().ToLower();
            bool error = false;
            if (actie == "n")
                currentLocation = currentLocation.GetLocationOnMove(Directions.North, playerInventory);
            else if (actie == "e")
                currentLocation = currentLocation.GetLocationOnMove(Directions.East, playerInventory);
            else if (actie == "w")
                currentLocation = currentLocation.GetLocationOnMove(Directions.West, playerInventory);
            else if (actie == "s")
                currentLocation = currentLocation.GetLocationOnMove(Directions.South, playerInventory);
            else if (actie == "x")
                Exit = true;
            else
            {
                error = true;
            }
            Console.Clear();
            if (error)
                Console.WriteLine("Unknown Action");
        }

        public void ShowActions()
        {
            Console.WriteLine("Mogelijke acties: (typ bijvoorbeeld n indien u naar het noorden wil)");
            Console.WriteLine("n= North");
            Console.WriteLine("e= East");
            Console.WriteLine("s= South");
            Console.WriteLine("w= West");

            Console.WriteLine("x=exit");
        }

        private List<Location> GameLocation = new List<Location>();
        private List<GameObject> Objects = new List<GameObject>();
        private List<GameObject> playerInventory = new List<GameObject>();
        private void InitGame()
        {
            // Make Locations
            Location l1 = new Location()
            {
                Title = "The Gate",
                Description = "You stand before a large grey gate that is ajar. Around you is barded wire, you can only got North, through the gate."
            };

            Location l2 = new Location()
            {
                Title = "Reception",
                Description = "The reception.... Little remains of what was once a vibrant surrounding. You see a few scattered skeletons belonging to, propably, students. A large gate to the South is ajar. You also see two doors on the Western and Eastern sides of the room."
            };

            // Place exits
            l1.Exits.Add(new Exit() { ExitDirection = Directions.North, GoesToLocation = l2 });

            l2.Exits.Add(new Exit() { ExitDirection = Directions.South, GoesToLocation = l1 });

            // Add location
            GameLocation.Add(l1);
            GameLocation.Add(l2);

            currentLocation = l1;

            Location l6 = new Location()
            {
                Title = "Hallway",
                Description = "A wide hallway where five people could easily move through, shoulder to shoulder. You see doors to both the East and the West."
            };

            Location l7 = new Location()
            {
                Title = "Computer room",
                Description = "Finnaly; you made it. The place where everyone wants to go: the Computerlabd!"
            };

            //Place objects in rooms
            GameObject keytol7 = new GameObject() { Description = "Rusty and large", Name = "Key" };
            l7.ObjectsInRoom.Add(keytol7);
            //...

            l6.Exits.Add(new Exit() { ExitDirection = Directions.West, GoesToLocation = l2, NeededObjects = new List<GameObject>() { keytol7 } });
            l6.Exits.Add(new Exit() { ExitDirection = Directions.East, GoesToLocation = l7 });

            //Voeg locatie toe
            //..
            GameLocation.Add(l6);
            GameLocation.Add(l7);
        }
    }
}
