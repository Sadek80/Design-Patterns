using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Adapter_Pattern
{
    public class SuperDrone : Drone
    {
        public void beep()
        {
            Console.WriteLine("Super drone is beeping....");
        }

        public void spinRotors()
        {
            Console.WriteLine("Super drone is spinning....");
        }

        public void takeOff()
        {
            Console.WriteLine("Super drone is taking off....");
        }
    }
}