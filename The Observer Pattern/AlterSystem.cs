using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Observer_Pattern
{
    public class AlterSystem : IObserver
    {
        private int temprature;
        private int pressure;
        private int windSpeed;
        public ISubject WeatherStation
        {
            get;
            set;
        }

        public AlterSystem(ISubject station)
        {
            this.WeatherStation = station;
            station.registerObserver(this);
        }
        public void alter()
        {
            Console.WriteLine("Alter");
            Console.WriteLine($"temp = {temprature}, pressure = {pressure}, and wind speed = {windSpeed}");
        }

        public void update(int temp, int press, int wind)
        {
            this.temprature = temp;
            this.pressure = press;
            this.windSpeed = wind;
            alter();
        }
    }
}