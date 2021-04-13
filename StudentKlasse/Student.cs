using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentKlasse
{
    class Student
    {
        public enum Klassen
        {
            EA1,
            EA2,
            EA3,
            EA4,
            EA5
        }

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public double BerekentTotaalCijfer()
        {
            return (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
        }

        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} jaar.");
            Console.WriteLine($"Klas: {Klas}");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine($"Cummunicatie: {PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles: {PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technology: {PuntenWebTech}");
            Console.WriteLine($"Gemiddelde: {BerekentTotaalCijfer():F2}");
        }
    }
}
