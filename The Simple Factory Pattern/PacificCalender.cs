using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Simple_Factory_Pattern
{
    public class PacificCalender : Calender
    {
        public PacificCalender()
        {
            ZoneFactory = new ZoneFactory();
        }
        public override void createCalender(string name)
        {
            Zone = ZoneFactory.createZone(name);
        }
    }
}