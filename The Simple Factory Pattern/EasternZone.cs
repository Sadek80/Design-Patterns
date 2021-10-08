using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Simple_Factory_Pattern
{
    public class EasternZone : IZone
    {
        public string Name
        {
            get => "Eastern";
            set => Name = value;
        }
        public int Id
        {
            get => -5;
            set => Id = value;
        }
    }
}