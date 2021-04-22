using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetDierenrijk
{
    class Mammal : Animal
    {
        public bool Pregnant { get; set; } = false;

        public Mammal(string name, bool pregnant) : base(name)
        {
            Pregnant = pregnant;
        }

        public override void Move()
        {
            Console.WriteLine("Mammal movement.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Pregnant: {Pregnant}");
        }
    }
}
