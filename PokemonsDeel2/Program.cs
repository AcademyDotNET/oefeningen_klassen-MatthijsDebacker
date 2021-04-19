using System;

namespace PokemonsDeel2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pokemon pokemon1 = new Pokemon();
            //pokemon1.ShowInfo();
            //Console.WriteLine();

            //Pokemon pokemon2 = new Pokemon(10, 12, 15, 20, 10, 5);
            //pokemon2.ShowInfo();
            //Console.WriteLine();

            //Pokemon pokemon3 = new Pokemon() { HP_Base = 10, Attack_Base = 5, Defence_Base = 20, SpecialAttack_Base = 15, SpecialDefence_Base = 30, Speed_Base = 10};
            //pokemon3.ShowInfo();
            //Console.WriteLine();

            Pokemon pokemon4 = Pokemon.GeneratePokemon("Floober", "Earth", 15);
            pokemon4.ShowInfo();
            Console.WriteLine();
            Pokemon pokemon5 = Pokemon.GeneratePokemon("Dibbydoo", "Water", 14);
            pokemon5.ShowInfo();
            Console.WriteLine();

            int result = Pokemon.Battle(pokemon4, pokemon5);

            switch (result)
            {
                case 0:
                    Console.WriteLine("No one won.");
                    break;
                case 1:
                    Console.WriteLine($"{pokemon4.Name} won!");
                    break;
                case 2:

                    Console.WriteLine($"{pokemon5.Name} won!");
                    break;
                default:
                    break;
            }

            Pokemon.Info();
        }
    }
}
