using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonsDeel2
{
    class Pokemon
    {
        // CONSTRUCTOR
        public Pokemon()
        {
            HP_Base = 10;
            Attack_Base = 10;
            Defence_Base = 10;
            SpecialAttack_Base = 10;
            SpecialDefence_Base = 10;
            Speed_Base = 10;
        }

        public Pokemon(int hp, int attack, int defence, int specialAttack, int specialDefence, int speed)
        {
            HP_Base = hp;
            Attack_Base = attack;
            Defence_Base = defence;
            SpecialAttack_Base = specialAttack;
            SpecialDefence_Base = specialDefence;
            Speed_Base = speed;
        }

        // STATIC PROPERTIES
        private static int LevelIncreases { get; set; } = 0;
        private static int Battles { get; set; } = 0;
        private static int Draws { get; set; } = 0;
        private static int GeneratedPokemon { get; set; } = 0;
        public static bool NoLevelingAllowed { get; set; } = false;

        // BASE STATS
        private int _HP_Base;

        public int HP_Base
        {
            get { return _HP_Base; }
            set { _HP_Base = value; }
        }

        private int _attack_Base;

        public int Attack_Base
        {
            get { return _attack_Base; }
            set { _attack_Base = value; }
        }

        private int _defence_Base;

        public int Defence_Base
        {
            get { return _defence_Base; }
            set { _defence_Base = value; }
        }

        private int _specialAttack_Base;

        public int SpecialAttack_Base
        {
            get { return _specialAttack_Base; }
            set { _specialAttack_Base = value; }
        }

        private int _specialDefence_Base;

        public int SpecialDefence_Base
        {
            get { return _specialDefence_Base; }
            set { _specialDefence_Base = value; }
        }


        private int _speed_Base;

        public int Speed_Base
        {
            get { return _speed_Base; }
            set { _speed_Base = value; }
        }

        // EXTRA STATS
        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }

        // LEVEL
        private int _level = 1;

        public int Level
        {
            get { return _level; }
            private set { _level = value; }
        }

        public void IncreaseLevel(int level = 1)
        {
            if (level > 0 && !NoLevelingAllowed)
            {
                for (int i = 0; i < level; i++)
                {
                    Level++;
                    LevelIncreases++;
                }
            }
            else if(NoLevelingAllowed)
            {
                Console.WriteLine("LEVELING RESTRICED, CANNOT LEVEL UP!");
            }
        }

        // STATISTICS
        public double Average
        {
            get
            {
                return (HP_Base + Attack_Base + Defence_Base + SpecialAttack_Base + SpecialDefence_Base + Speed_Base) / 6.0;
            }
        }
        public int Total
        {
            get
            {
                return HP_Base + Attack_Base + Defence_Base + SpecialAttack_Base + SpecialDefence_Base + Speed_Base;
            }
        }

        // LEVEL BASED STATS
        public int HP_Full
        {
            get
            {
                return (((HP_Base + 50) * Level) / 50) + 10;
            }
        }

        public int Attack_Full
        {
            get
            {
                return (((Attack_Base + 50) * Level) / 50) + 10;
            }
        }

        public int Defence_Full
        {
            get
            {
                return (((Defence_Base + 50) * Level) / 50) + 10;
            }
        }

        public int SpecialAttak_Full
        {
            get
            {
                return (((SpecialAttack_Base + 50) * Level) / 50) + 10;
            }
        }

        public int SpecialDefence_Full
        {
            get
            {
                return (((SpecialDefence_Base + 50) * Level) / 50) + 10;
            }
        }

        public int Speed_Full
        {
            get
            {
                return (((Speed_Base + 50) * Level) / 50) + 10;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"#{Number}: {Name} (level {Level}) (Type: {Type})");
            Console.WriteLine("Base stats:");
            Console.WriteLine($"\t* Health = {HP_Base}");
            Console.WriteLine($"\t* Attack = {Attack_Base}");
            Console.WriteLine($"\t* Defence = {Defence_Base}");
            Console.WriteLine($"\t* Special Attack = {SpecialAttack_Base}");
            Console.WriteLine($"\t* Special Defence = {SpecialDefence_Base}");
            Console.WriteLine($"\t* Speed = {Speed_Base}");
            Console.WriteLine("Full stats:");
            Console.WriteLine($"\t* Health = {HP_Full}");
            Console.WriteLine($"\t* Attack = {Attack_Full}");
            Console.WriteLine($"\t* Defence = {Defence_Full}");
            Console.WriteLine($"\t* Special Attack = {SpecialAttak_Full}");
            Console.WriteLine($"\t* Special Defence = {SpecialDefence_Full}");
            Console.WriteLine($"\t* Speed = {Speed_Full}");
        }

        // STATIC METHODS

        static public Pokemon GeneratePokemon(string name, string type, int number)
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

            GeneratedPokemon++;
            return pokemon;
        }

        public static int Battle(Pokemon pokemon1, Pokemon pokemon2)
        {
            Battles++;

            if (pokemon1 == null && pokemon2 == null)
            {
                Draws++;
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
            Pokemon first, second;

            if (pokemon1.Speed_Full >= pokemon2.Speed_Full)
            {
                first = pokemon1;
                second = pokemon2;
            }
            else
            {
                first = pokemon2;
                second = pokemon1;
            }
            Console.WriteLine($"{first.Name} attacks first!");

            while (health1 > 0 && health2 > 0)
            {
                damage = Math.Clamp((-first.Attack_Full + second.Defence_Full), int.MinValue, 0);
                health2 += damage;
                Console.WriteLine($"{first.Name} hits {second.Name} with {Math.Abs(damage)} damage, its super effective.");
                if (health2 < 0)
                {
                    return 1;
                }
                else if (health1 < 0)
                {
                    return 2;
                }

                damage = Math.Clamp((-second.Attack_Full + first.Defence_Full), int.MinValue, 0);
                health1 += damage;
                Console.WriteLine($"{second.Name} hits {first.Name} with {Math.Abs(damage)} damage, its super effective.");
                if (health2 < 0)
                {
                    return 1;
                }
                else if (health1 < 0)
                {
                    return 2;
                }

                if (health1 == pokemon1.HP_Full && health2 == pokemon2.HP_Full)
                {
                    Console.WriteLine("The defences are too high, no damage is being done.");
                    Draws++;
                    return 0;
                }
            }
            Draws++;
            return 0;
        }

        public static void Info()
        {
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("GLOBAL STATS");
            Console.WriteLine($"Number of levelups: {LevelIncreases}");
            Console.WriteLine($"Number of battles: {Battles}");
            Console.WriteLine($"Number of draws: {Draws}");
            Console.WriteLine($"Number of generated pokemen: {GeneratedPokemon}");
            Console.WriteLine(new string('=', 20));
        }
    }
}
