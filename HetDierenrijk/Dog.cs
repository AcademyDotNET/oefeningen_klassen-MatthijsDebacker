using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetDierenrijk
{
    class Dog : Mammal
    {
        public string Breed { get; set; }

        public Dog(string name, bool pregnant, string breed) : base(name, pregnant) 
        {
            Breed = breed;
        }

        public override void Move()
        {
            Console.WriteLine("Dog movement.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Breed: {Breed}");
        }
    }
}
