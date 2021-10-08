using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Observer_Pattern
{
    public class UserInterface : IObserver
    {
        private int temprature;
        private int pressure;
        private int windSpeed;
        public ISubject WeatherStation
        {
            get;
            set;
        }

        public UserInterface(ISubject station)
        {
            this.WeatherStation = station;
            station.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("User Interfac......");
            Console.WriteLine($"temp = {temprature}, pressure = {pressure}, and wind speed = {windSpeed}");
        }

        public void update(int temp, int press, int wind)
        {
            this.temprature = temp;
            this.pressure = press;
            this.windSpeed = wind;
            display();
        }
    }
}