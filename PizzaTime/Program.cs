using System;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza();
            pizza1.Toppings = "";
            pizza1.Diameter = -2;
            pizza1.Price = -600.0;
            pizza1.PrintPizza();

            Pizza pizza2 = new Pizza();
            pizza2.Toppings = "Pineapple";
            pizza2.Diameter = 1;
            pizza2.Price = 6000.0;
            pizza2.PrintPizza();

            Pizza pizza3 = new Pizza();
            pizza3.Toppings = "Margherita";
            pizza3.Diameter = 10;
            pizza3.Price = 10.0;
            pizza3.PrintPizza();

        }
    }
}
