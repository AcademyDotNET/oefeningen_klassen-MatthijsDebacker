using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTester
{
    class Pokemon
    {
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
            if (level > 0)
            {
                for (int i = 0; i < level; i++)
                {
                    Level++;
                }
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
    }
}
