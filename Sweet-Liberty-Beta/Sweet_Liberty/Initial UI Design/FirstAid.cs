using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_UI_Design
{
    internal class FirstAid : Item
    {
        public int Value { get; set; }
        public FirstAid(string name, string description, int value) : base(name, description)
        {
            Value = value;
        }

    }
}
