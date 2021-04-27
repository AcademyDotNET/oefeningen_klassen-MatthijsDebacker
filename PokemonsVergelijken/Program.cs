using System;

namespace PokemonsVergelijken
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon1 = Pokemon.GeneratePokemon("Dibbydoo", "Water", 14);
            Pokemon pokemon2 = pokemon1;
            Pokemon pokemon3 = Pokemon.GeneratePokemon("Dobadee", "Fire", 12);

            Console.WriteLine(pokemon1.Equals(pokemon2));
            Console.WriteLine(pokemon1.Equals(pokemon3));
        }
    }
}
