using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    abstract class Animal
    {
        public double Weight { get; set; }

        public Animal()
        {
            Random rand = new Random();
            Weight = 10.0 + rand.NextDouble() * rand.Next(10, 101);
        }

        public abstract void Says();

        public override string ToString()
        {
            return $"{this.GetType()} (Weight {Weight})";
        }
    }
}
