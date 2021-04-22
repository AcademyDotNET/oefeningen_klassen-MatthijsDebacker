using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetDierenrijk
{
    class Cow : Mammal
    {
        public double MilkProduced { get; set; }

        public Cow(string name, bool pregnant, double milkProduced) : base(name, pregnant)
        {
            MilkProduced = milkProduced;
        }

        public override void Move()
        {
            Console.WriteLine("Cow movement.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Produced milk: {MilkProduced}");
        }
    }
}
