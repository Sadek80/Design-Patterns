using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Adapter_Pattern
{
    public class MulardDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("Mulard Duck is Flying....");
        }

        public void quack()
        {
            Console.WriteLine("Mulard Duck is quacking....");
        }
    }
}