using System;

namespace EenEigenHuis
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Room[] rooms = new Room[5];

            // Create rooms
            Bathroom bathRoom = new Bathroom("Bathroom", 6.0);

            Bedroom bedRoom = new Bedroom("Bedroom", 12.0);

            Hallway hallway = new Hallway("Hallway", 6.0);

            Kitchen kitchen = new Kitchen("Kitchen", 7.0);

            Lounge lounge = new Lounge("Lounge", 15.0);

            rooms[0] = bathRoom;
            rooms[1] = bedRoom;
            rooms[2] = hallway;
            rooms[3] = kitchen;
            rooms[4] = lounge;

            house.Rooms = rooms;

            Console.WriteLine(house);
            Console.WriteLine($"Total price: {house.CalculatePrice()}");
        }
    }
}
