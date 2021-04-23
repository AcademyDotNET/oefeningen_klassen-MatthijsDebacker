using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class TextBook : Book
    {
        public int GradeLevel { get; set; }
        public override double Price 
        { 
            get => base.Price; 
            set
            {
                if (value >= 20 && value <= 80)
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
