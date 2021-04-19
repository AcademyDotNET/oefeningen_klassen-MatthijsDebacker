using System;

namespace MeetlatConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Meetlat meetLat = new Meetlat(2.5);
            Console.WriteLine($"KiloMeters: {meetLat.LengteInKm:F4}\nMeters: {meetLat.LengteInM:F4}\nCentimeters: {meetLat.LengteInCm:F2}\nVoet: {meetLat.LengteInVoet:F4}");
        }
    }
}
