using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Simple_Factory_Pattern
{
    public class ZoneFactory
    {
        public IZone Zone
        {
            get;
            set;
        }

        public IZone createZone(string zone)
        {
            if(zone == "pacific")
            {
                Zone = new PacificZone();
            }

            else if(zone == "eastern")
            {
                Zone = new EasternZone();
            }
            return Zone;
        }
    }
}