using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Simple_Factory_Pattern
{
    public class PacificZone : IZone
    {
        public string Name 
        {
            get => "Pacific"; 
            set => Name = value; 
        }
        public int Id 
        { 
            get => -8;
            set => Id = value;
        }
    }
}