using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1
            Pokemon charmander = new Pokemon();
            charmander.Name = "Charmander";
            charmander.Type = "Fire";
            charmander.Number = 4;
            charmander.HP_Base = 39;
            charmander.Attack_Base = 52;
            charmander.Defence_Base = 43;
            charmander.SpecialAttack_Base = 50;
            charmander.SpecialDefence_Base = 50;
            charmander.Speed_Base = 65;

            Pokemon sandshrew = new Pokemon();
            sandshrew.Name = "Sandshrew";
            sandshrew.Type = "Ground";
            sandshrew.Number = 27;
            sandshrew.HP_Base = 50;
            sandshrew.Attack_Base = 75;
            sandshrew.Defence_Base = 85;
            sandshrew.SpecialAttack_Base = 30;
            sandshrew.SpecialDefence_Base = 30;
            sandshrew.Speed_Base = 40;

            Pokemon poliwag = new Pokemon();
            poliwag.Name = "Poliwag";
            poliwag.Type = "Water";
            poliwag.Number = 60;
            poliwag.HP_Base = 40;
            poliwag.Attack_Base = 50;
            poliwag.Defence_Base = 40;
            poliwag.SpecialAttack_Base = 40;
            poliwag.SpecialDefence_Base = 40;
            poliwag.Speed_Base = 90;

            for (int i = 0; i < 110; i++)
            {
                Console.Clear();
                poliwag.IncreaseLevel();
                poliwag.ShowInfo();
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
