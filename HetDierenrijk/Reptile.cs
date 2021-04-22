using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetDierenrijk
{
    class Reptile : Animal
    {
        public int EggsLaid { get; set; }

        public Reptile(string name, int eggsLaid) : base(name)
        {
            EggsLaid = eggsLaid;
        }

        public override void Move()
        {
            Console.WriteLine("Reptile movement.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Eggs laid: {EggsLaid}.");
        }
    }
}
