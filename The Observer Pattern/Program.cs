using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();

            Logger logger = new Logger(station);
            AlterSystem alter = new AlterSystem(station);
            UserInterface uInterface = new UserInterface(station);


            station.setState(20, 30, 40);


        }
    }
}
