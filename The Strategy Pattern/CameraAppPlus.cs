using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Strategy_Pattern
{
    public class CameraAppPlus : PhoneCameraApp
    {
        public CameraAppPlus()
        {
            setShareMethod(new ShareToSocial());
        }
        public override void edit()
        {
            Console.WriteLine("camera plus editing...");
        }
    }
}