using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Decorator_Pattern
{
    public class Pepper : Toppings
    {
        public Pizza Pizza
        {
            get;
            set;
        }


        public Pepper(Pizza pizza)
        {
            this.Pizza = pizza;
            description = pizza.description + ", adding pepper";
        }

        public override double cost()
        {
            return Pizza.cost() + .10;
        }
    }
}