using System;

namespace PokemonExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = Pokemon.GeneratePokemon("Dibbydoo", "Water", 14);
            Console.WriteLine(pokemon.ToString());
        }
    }
}
