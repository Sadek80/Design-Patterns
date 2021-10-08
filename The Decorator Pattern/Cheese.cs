using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Decorator_Pattern
{
    public class Cheese : Toppings
    {
        public Pizza Pizza
        {
            get;
            set;
        }

    

        public Cheese(Pizza pizza)
        {
            this.Pizza = pizza;
            description = pizza.description + ", Extra Cheese";
        }
        public override double cost()
        {
            return Pizza.cost() + .20;
        }
    }
}