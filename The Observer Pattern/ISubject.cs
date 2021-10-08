using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Observer_Pattern
{
    public interface ISubject
    {

        void registerObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyObservers();
    }
}