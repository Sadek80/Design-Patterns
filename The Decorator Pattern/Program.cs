using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza thinPizza = new ThinCrustPizza();
            Pizza thickPizza = new ThickCrustPizza();


            Console.WriteLine(thinPizza.description);
            thinPizza = new Cheese(thinPizza);
            Console.WriteLine(thinPizza.description + ": "+ thinPizza.cost());

            Console.WriteLine(thickPizza.description);
            thickPizza = new Cheese(thickPizza);
            thickPizza = new Pepper(thickPizza);
            thickPizza = new Olives(thickPizza);
            Console.WriteLine(thickPizza.description + ": "+thickPizza.cost());
        }
    }
}
