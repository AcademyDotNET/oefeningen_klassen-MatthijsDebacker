using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetDierenrijk
{
    class Rabbit : Mammal
    {
        public double JumpHeight { get; set; }

        public Rabbit(string name, bool pregnant, double jumpHeight) : base(name, pregnant)
        {
            JumpHeight = jumpHeight;
        }

        public override void Move()
        {
            Console.WriteLine("Rabbit movement.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Jump height: {JumpHeight}.");
        }
    }
}
