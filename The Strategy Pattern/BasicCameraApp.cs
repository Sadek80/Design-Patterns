using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Strategy_Pattern
{
    public class BasicCameraApp : PhoneCameraApp
    {
        public BasicCameraApp()
        {
            setShareMethod(new ShareToText());
        }
        public override void edit()
        {
            Console.WriteLine("basic camera editing...");
        }
    }
}