using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing the objects
            BasicCameraApp basic = new BasicCameraApp();
            CameraAppPlus plus = new CameraAppPlus();

            // Perform the sharing interface method
            basic.performShareMethod();
            plus.performShareMethod();
        }
    }
}
