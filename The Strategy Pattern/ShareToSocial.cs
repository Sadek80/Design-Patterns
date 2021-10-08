using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Strategy_Pattern
{
    public class ShareToSocial : IShareMethod
    {
        public void share()
        {
            Console.WriteLine("Sharing to social media....");
        }
    }
}