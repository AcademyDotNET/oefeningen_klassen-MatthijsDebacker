using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetDierenrijk
{
    class Iguana : Reptile
    {
        public string Color { get; set; }

        public Iguana(string name, int eggsLaid, string color) : base(name, eggsLaid)
        {
            Color = color;
        }

        public override void Move()
        {
            Console.WriteLine("Iguana movement.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Color: {Color}.");
        }
    }
}
