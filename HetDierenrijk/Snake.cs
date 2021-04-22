using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetDierenrijk
{
    class Snake : Reptile
    {
        public double Length { get; set; }

        public Snake(string name, int eggsLaid, double length) : base(name, eggsLaid)
        {
            Length = length;
        }

        public override void Move()
        {
            Console.WriteLine("Snake movement.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Length: {Length}.");
        }
    }
}
