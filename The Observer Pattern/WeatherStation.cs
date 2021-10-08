using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Observer_Pattern
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> observables;
        public int Temprature
        {
            get;
            set;
        }

        public int WindSpeed
        {
            get;
            set;
        }

        public int Pressure
        {
            get;
            set;
        }

        public WeatherStation()
        {
            observables = new List<IObserver>();
        }

        public void setState(int temp, int press, int speed)
        {
            this.Pressure = press;
            this.Temprature = temp;
            this.WindSpeed = speed;
            notifyObservers();
        }

        public int[] getState()
        {
            int[] arr = new int[] { Temprature, Pressure, WindSpeed };
            return arr;
        }

        public void notifyObservers()
        {
            foreach (var observer in observables)
            {
                observer.update(Temprature, Pressure, WindSpeed);
            }
        }

        public void registerObserver(IObserver observable)
        {
            observables.Add(observable);
        }

        public void removeObserver(IObserver observable)
        {
            observables.Remove(observable);
        }
    }
}