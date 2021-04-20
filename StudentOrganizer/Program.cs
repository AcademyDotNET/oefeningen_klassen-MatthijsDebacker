using System;
using System.Collections.Generic;

namespace StudentOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student());
            students.Add(new Student());
            students.Add(new Student());
            students.Add(new Student());
            students.Add(new Student());

            int input = 1;

            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1) Enter student data.");
                Console.WriteLine("2) Print student data.");
                Console.WriteLine("3) Remove student data.");

                input = Math.Clamp(AskForInt(""), int.MinValue, 3);

                if (input == 1)
                {
                    EnterData(students);
                }
                else if (input == 2)
                {
                    foreach (Student student in students)
                    {
                        if(student.Naam != "Empty")
                        {
                            student.GeefOverzicht();
                            Console.WriteLine();
                        }
                    }
                } 
                else if(input == 3)
                {
                    RemoveData(students);
                }
            } while (input > 0) ;
        }

        static void EnterData(List<Student> list)
        {
            int input = Math.Clamp(AskForInt("Which student? (1 - 5)"), 1, 5);
            if(list[input].Naam != "Empty")
            {
                Console.WriteLine("Can the current data be overwritten? (y/n)");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                    case "Y":
                        Console.WriteLine("Overwriting data.");
                        break;
                    case "n":
                    case "N":
                        return;
                    default:
                        Console.WriteLine("Unclear response, doing nothing.");
                        return;
                }
            }

            Console.WriteLine("Name: ");
            list[input].Naam = Console.ReadLine();
            list[input].Leeftijd = AskForInt("Age: ");
            list[input].Klas = (Klassen)Math.Clamp(AskForInt("Class (1 - 4): "), 1, 4);
            list[input].PuntenCommunicatie = Math.Clamp(AskForInt("Grade for Communication (0 - 20): "), 0, 20);
            list[input].PuntenProgrammingPrinciples = Math.Clamp(AskForInt("Grade for Programming Principles (0 - 20): "), 0, 20);
            list[input].PuntenWebTech = Math.Clamp(AskForInt("Grade for Web Tech (0 - 20): "), 0, 20);
        }

        static void RemoveData(List<Student> list)
        {
            int input = Math.Clamp(AskForInt("Which student? (1 - 5)"), 1, 5);
            if (list[input].Naam == "Empty")
            {
                Console.WriteLine("Student data already empty");
            }
            else
            {
                list[input] = new Student();
            }
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
