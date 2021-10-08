using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Simple_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Calender calender = new PacificCalender();

            calender.createCalender("pacific");

            calender.print();

            calender.createCalender("eastern");

            calender.print();
           
        }
    }
}
