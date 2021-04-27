using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierentuinAdvanced
{
    class Dog : Animal
    {
        public override void Says()
        {
            Console.WriteLine("Bark bark bark.");
        }
    }
}
