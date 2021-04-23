using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class CoffieTableBook : Book
    {
        public override double Price 
        {
            get => base.Price; 
            set
            {
                if(value >= 35 && value <= 100)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine($"Invalid price for {ToString()}");
                }
            }
        }
    }
}
