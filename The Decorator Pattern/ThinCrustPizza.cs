using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Decorator_Pattern
{
    public class ThinCrustPizza : Pizza
    {
        public ThinCrustPizza()
        {
            description = "thin crust pizza";
        }
        public override double cost()
        {
            return 110;
        }
    }
}