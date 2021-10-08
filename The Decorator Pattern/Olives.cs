using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Decorator_Pattern
{
    public class Olives : Toppings
    {
        public Pizza Pizza
        {
            get;
            set;
        }

      

        public Olives(Pizza pizza)
        {
            this.Pizza = pizza;
            description = pizza.description + ", Add olives";
        }
        public override double cost()
        {
            return Pizza.cost() + .15;
        }
    }
}