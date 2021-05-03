using System;

//  1) Maak een programma (klasse) dat voor elke mogelijke lijst van types kan gebruiken. 
//  Aan deze lijst willen we dan items kunnen toevoegen maar ook uit kunnen verwijderen
//  (denk meerdere methodes) 
//  Ik wil ook een optie om de items in de lijst weer te geven, waarbij ik dan 
//  elk item ook individueel kan benaderen.
//  PT2: Maak dit mogelijk voor objecten. Stel dat ik een lijst v studenten heb wil ik voor
//  elke specifieke student in de lijst de waardes kunnen aanpassen. 
//  (ik selecteer een student en bewerk deze)

namespace GenericListTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(0, 11));
            }

            list.PrintList();

            list.Remove(5);
            list.RemoveAt(3);

            list.PrintList();

            GenericList<Student> studentList = new GenericList<Student>();
            for (int i = 0; i < 10; i++)
            {
                studentList.Add(new Student($"Student{i}", rand.Next(0, 21)));
            }

            studentList.PrintList();

            studentList.Remove(studentList.GList[2]);
            studentList.RemoveAt(5);

            studentList.Get(4).Name = "NewName";

            studentList.PrintList();
        }
    }
}
