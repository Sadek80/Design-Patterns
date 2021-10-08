using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Observer_Pattern
{
    public interface IObserver
    {
        void update(int temprature, int pressure, int windSpeed);
    }
}