using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Adapter_Pattern
{
    public interface Drone
    {
        void beep();
        void spinRotors();
        void takeOff();
    }
}