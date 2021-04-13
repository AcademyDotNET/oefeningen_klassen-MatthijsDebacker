using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Pizza
    {
        private string _toppings = "Standard";
        private int _diameter = 5;
        private double _price = 10.0;

        public string Toppings 
        { 
            get 
            { 
                return _toppings;
            } 
            set 
            { 
                if(value != "")
                {
                    _toppings = value; 
                }
            } 
        }

        public int Diameter 
        { 
            get 
            {
                return _diameter; 
            } 
            set 
            { 
                if(value > 0)
                {
                    _diameter = value; 
                }
            } 
        }
        
        public double Price 
        { 
            get 
            {
                return _price; 
            } 
            set 
            { 
                if(value >= 0.0)
                {
                    _price = value; 
                }
            } 
        }

        public void PrintPizza()
        {
            Console.WriteLine($"Toppings: {_toppings}");
            Console.WriteLine($"Diameter: {_diameter}");
            Console.WriteLine($"Price: {_price:F2}");
            Console.WriteLine();
        }
    }
}
