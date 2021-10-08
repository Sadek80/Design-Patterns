using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Strategy_Pattern
{
    public abstract class PhoneCameraApp
    {
        public IShareMethod ShareMethod
        {
            get;
            set;
        }

        public void Take()
        {
            Console.WriteLine("take a photo....");
        }

        public void save()
        {
            Console.WriteLine("save a photo");
        }

        public abstract void edit();

        public void setShareMethod(IShareMethod method)
        {
            ShareMethod = method;
        }

        public void performShareMethod()
        {
            ShareMethod.share();
        }
    }
}