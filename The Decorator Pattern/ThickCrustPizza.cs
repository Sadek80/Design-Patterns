using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Decorator_Pattern
{
    public class ThickCrustPizza : Pizza
    {
        
        public ThickCrustPizza()
        {
            description = "thick crust pizza";
        }

        public override double cost()
        {
            return .99;
        }
    }
}