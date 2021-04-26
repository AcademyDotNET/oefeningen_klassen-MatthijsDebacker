using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Room
    {
        public double Size { get; set; } = 10.0;
        public string Name { get; set; } = "Room";
        public virtual double Price 
        {
            get
            {
                return 400.0;
            }
        }

        public Room(string name, double size)
        {
            Name = name;
            Size = size;
        }

        public override string ToString()
        {
            return $"{Name}, {Size} square meters, {Price:C}";
        }
    }
}
