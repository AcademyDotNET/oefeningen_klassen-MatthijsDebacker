using System;
using System.Collections.Generic;

namespace HetDierenrijk
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit("rabbit", false, 1.5);
            Cow cow = new Cow("cow", true, 2.5);
            Dog dog = new Dog("dog", false, "labrador");
            Snake snake = new Snake("snake", 12, 1.5);
            Iguana iguana = new Iguana("iguana", 2, "green");

            List<Animal> animals = new List<Animal>();
            animals.Add(rabbit);
            animals.Add(cow);
            animals.Add(dog);
            animals.Add(snake);
            animals.Add(iguana);

            foreach (Animal animal in animals)
            {
                animal.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}
