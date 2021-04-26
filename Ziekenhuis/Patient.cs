using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis
{
    class Patient
    {
        public string Name { get; set; }
        public int Hours { get; set; }

        public Patient(string name, int hours)
        {
            Name = name;
            Hours = hours;
        }

        public virtual double CalculateCost()
        {
            return 50 + 20 * Hours;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Patient: {Name} Costs: {CalculateCost()}");
        }
    }
}
