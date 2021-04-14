using System;

namespace PokemonTester
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Console.WriteLine("Enter your own pokemon:");
            //Console.WriteLine("Name: ");
            //Pokemon userPokemon = new Pokemon();
            //userPokemon.Name = Console.ReadLine();
            //Console.WriteLine("Type: ");
            //userPokemon.Type = Console.ReadLine();
            //userPokemon.Number = AskForInt("Number:");
            //userPokemon.HP_Base = AskForInt("HP:");
            //userPokemon.Attack_Base = AskForInt("Attack:");
            //userPokemon.Defence_Base = AskForInt("Defence:");
            //userPokemon.SpecialAttack_Base = AskForInt("Special Attack:");
            //userPokemon.SpecialDefence_Base = AskForInt("special Defence");
            //userPokemon.Speed_Base = AskForInt("Speed:");

            //Console.WriteLine();
            //userPokemon.ShowInfo();
            //Console.WriteLine();

            //userPokemon.IncreaseLevel(AskForInt("What level is your pokemon?"));

            //Console.WriteLine();
            //userPokemon.ShowInfo();
            //Console.WriteLine();

            Pokemon pok1 = PokemonGenerator("Flewbergoose", "Fire", 1);
            Pokemon pok2 = PokemonGenerator("Flawbergeese", "Water", 2);


            Console.WriteLine();
            pok1.ShowInfo();
            Console.WriteLine();
            pok2.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("FIGHT!");
            Console.WriteLine();

            int result = Battle(pok1, pok2);

            switch (result)
            {
                case 0:
                    Console.WriteLine("No one won.");
                    break;
                case 1:
                    Console.WriteLine($"{pok1.Name} won!");
                    break;
                case 2:

                    Console.WriteLine($"{pok2.Name} won!");
                    break;
                default:
                    break;
            }
        }

        static int AskForInt(string question, string errorResponse = "Invalid number, please try again", bool clear = false)
        {
            Console.WriteLine(question);
            int input = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out input))
            {
                if (clear)
                {
                    Console.Clear();
                }
                Console.WriteLine(errorResponse);
                sInput = Console.ReadLine();
            }

            return input;
        }

        static Pokemon PokemonGenerator(string name, string type, int number)
        {
            Random rand = new Random();
            Pokemon pokemon = new Pokemon();
            pokemon.Name = name;
            pokemon.Type = type;
            pokemon.Number = number;
            pokemon.HP_Base = rand.Next(10, 251);
            pokemon.Attack_Base = rand.Next(5, 135);
            pokemon.Defence_Base = rand.Next(5, 181);
            pokemon.SpecialAttack_Base = rand.Next(20, 155);
            pokemon.SpecialDefence_Base = rand.Next(20, 155);
            pokemon.Speed_Base = rand.Next(15, 141);
            pokemon.IncreaseLevel(rand.Next(1, 101));

            return pokemon;
        }

        static int Battle(Pokemon pokemon1, Pokemon pokemon2)
        {
            if (pokemon1 == null && pokemon2 == null)
            {
                return 0;
            }
            else if (pokemon2 == null)
            {
                return 1;
            }
            else if (pokemon1 == null)
            {
                return 2;
            }

            int health1 = pokemon1.HP_Full;
            int health2 = pokemon2.HP_Full;
            int damage = 0;

            if (pokemon1.Speed_Full >= pokemon2.Speed_Full)
            {
                Console.WriteLine($"{pokemon2.Name} attacks first!");
                while (health1 > 0 && health2 > 0)
                {
                    damage = Math.Clamp((-pokemon1.Attack_Full + pokemon2.Defence_Full), int.MinValue, 0);
                    health2 += damage;
                    Console.WriteLine($"{pokemon1.Name} hits {pokemon2.Name} with {damage} damage, its super effective.");
                    if (health2 < 0)
                    {
                        return 1;
                    }

                    damage = Math.Clamp((-pokemon2.Attack_Full + pokemon1.Defence_Full), int.MinValue, 0);
                    health1 += damage;
                    Console.WriteLine($"{pokemon2.Name} hits {pokemon1.Name} with {damage} damage, its super effective.");
                    if (health1 < 0)
                    {
                        return 2;
                    }

                    if(health1 == pokemon1.HP_Full && health2 == pokemon2.HP_Full)
                    {
                        Console.WriteLine("The defences are too high, no damage is being done.");
                        return 0;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{pokemon2.Name} attacks first!");
                while (health1 > 0 && health2 > 0)
                {
                    damage = Math.Clamp((-pokemon2.Attack_Full + pokemon1.Defence_Full), int.MinValue, 0);
                    health1 += damage;
                    Console.WriteLine($"{pokemon2.Name} hits {pokemon1.Name} with {damage} damage, its super effective.");
                    if (health1 < 0)
                    {
                        return 2;
                    }

                    damage = Math.Clamp((-pokemon1.Attack_Full + pokemon2.Defence_Full), int.MinValue, 0);
                    health2 += damage;
                    Console.WriteLine($"{pokemon1.Name} hits {pokemon2.Name} with {damage} damage, its super effective.");
                    if (health2 < 0)
                    {
                        return 1;
                    }

                    if (health1 == pokemon1.HP_Full && health2 == pokemon2.HP_Full)
                    {
                        Console.WriteLine("The defences are too high, no damage is being done.");
                        return 0;
                    }
                }
            }


            return 0;
        }
    }
}
