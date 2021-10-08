using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Adapter_Pattern
{
    public class DuckSimulator
    {
        static Duck duck
        {
            get;
            set;
        }

        static void testDuck(Duck duck)
        {
            duck.fly();
            duck.quack();
        }

        static void Main()
        {
            duck = new MulardDuck();
            testDuck(duck);

            Drone drone = new SuperDrone();
            Adapter adapter = new Adapter(drone);
            testDuck(adapter);
        }
    }
}