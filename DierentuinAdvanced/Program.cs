using System;
using System.Collections.Generic;

namespace DierentuinAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input.ToLower() != "q")
            {
                List<Animal> animals = new List<Animal>();
                while (input.ToLower() != "q")
                {
                    Console.WriteLine("What animal do you wish to add to the list?");
                    Console.WriteLine("Cat");
                    Console.WriteLine("Cow");
                    Console.WriteLine("Dog");
                    Console.WriteLine("Duck");
                    Console.WriteLine("Panther");
                    input = Console.ReadLine();
                    Console.Clear();

                    AddAnimal(animals, input.ToLower());
                }

                input = "";
                while (input.ToLower() != "d")
                {

                    Console.WriteLine("What do you want to do now?");
                    Console.WriteLine("a. Remove animal.");
                    Console.WriteLine("b. Show average weight.");
                    Console.WriteLine("c. Get the animals to say something.");
                    Console.WriteLine("d. Start again.");
                    Console.WriteLine("q. Quit.");
                    input = Console.ReadLine();
                    Console.Clear();

                    switch (input.ToLower())
                    {
                        case "a":
                            RemoveAnimal(animals);
                            break;
                        case "b":
                            ShowAverageWeight(animals);
                            break;
                        case "c":
                            LetAnimalsSpeak(animals);
                            break;
                        default:
                            break;
                    }

                }

            }
        }

        static void AddAnimal(List<Animal> animals, string name)
        {
            switch (name)
            {
                case "cat":
                    animals.Add(new Cat());
                    break;
                case "cow":
                    animals.Add(new Cow());
                    break;
                case "dog":
                    animals.Add(new Dog());
                    break;
                case "duck":
                    animals.Add(new Duck());
                    break;
                case "panther":
                    animals.Add(new Panther());
                    break;
                default:
                    Console.WriteLine("Cannot add this animal to the list. What is it anyway?");
                    break;
            }
        }

        static void RemoveAnimal(List<Animal> animals)
        {
            ShowList(animals);
            int index = AskForInt("Which animal do you wish to slaugh- remove?");
            if (index >= 0 && index <= animals.Count)
            {
                animals.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void LetAnimalsSpeak(List<Animal> animals)
        {
            Console.WriteLine("Which animals should speak?");
            Console.WriteLine("Cat");
            Console.WriteLine("Cow");
            Console.WriteLine("Dog");
            Console.WriteLine("Duck");
            Console.WriteLine("Panther");
            string input = Console.ReadLine();

            foreach (Animal animal in animals)
            {
                switch (input.ToLower())
                {
                    case "cat":
                        if(animal is Cat)
                        {
                            animal.Says();
                        }
                        break;
                    case "cow":
                        if (animal is Cow)
                        {
                            animal.Says();
                        }
                        break;
                    case "dog":
                        if (animal is Dog)
                        {
                            animal.Says();
                        }
                        break;
                    case "duck":
                        if (animal is Duck)
                        {
                            animal.Says();
                        }
                        break;
                    case "panther":
                        if (animal is Panther)
                        {
                            animal.Says();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        static void ShowAverageWeight(List<Animal> animals)
        {
            double total = 0.0;
            foreach (Animal animal in animals)
            {
                total += animal.Weight;
            }
            Console.WriteLine($"The average weight of all animals is: {(total / animals.Count):F2}");
        }

        static void ShowList(List<Animal> animals)
        {
            Console.WriteLine();
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"{i}) {animals[i]}");
            }
            Console.WriteLine();
        }

        static int AskForInt(string question, string errorResponse = "Invalid number, please try again", bool clear = false)
        {
            Console.WriteLine(question);
            int input = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out input))
            {
                if (clear)
                {
                    Console.Clear();
                }
                Console.WriteLine(errorResponse);
                sInput = Console.ReadLine();
            }

            return input;
        }
    }
}