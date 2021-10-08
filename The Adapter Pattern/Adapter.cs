using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Adapter_Pattern
{
    public class Adapter : Duck
    {
        public Drone drone
        {
            get;
            set;
        }

        public Adapter(Drone drone)
        {
            this.drone = drone;
        }

        public void fly()
        {
            drone.takeOff();
        }

        public void quack()
        {
            drone.beep();
        }
    }
}