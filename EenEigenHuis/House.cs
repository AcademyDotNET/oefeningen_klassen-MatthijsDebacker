using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class House
    {
        public Room[] Rooms { get; set; }

        public double CalculatePrice()
        {
            double price = 0.0;

            foreach (Room room in Rooms)
            {
                price += room.Price;
            }

            return price;
        }

        public override string ToString()
        {
            string str = "This house has the following rooms: ";

            if (Rooms != null)
            {
                foreach (Room room in Rooms)
                {
                    str += $"\n{room}";
                }
            }

            return str;
        }
    }
}
