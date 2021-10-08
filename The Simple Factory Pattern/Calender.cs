using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Simple_Factory_Pattern
{
    public abstract class Calender
    {
        public IZone Zone
        {
            get;
            set;
        }

        private ZoneFactory factory;
        public ZoneFactory ZoneFactory
        {
            get => factory;
            set => factory = value;
        }

        public void print()
        {
            Console.WriteLine($"this is the main Calendar: with {Zone.Name} : {Zone.Id}");
        }

        public abstract void createCalender(string name);
    }
}