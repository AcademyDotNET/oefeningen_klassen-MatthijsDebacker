using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetDierenrijk
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal movement.");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}.");
        }
    }
}
