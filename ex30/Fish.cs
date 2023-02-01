using Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28_template
{
    internal class Fish : Animal
    {
        public string taste;
        public string Taste
        {
            get { return taste; }
        }
        public Fish(string tas, DateTime bd, string n, float w, float h, float d, float we) : base(bd, n, w, h, d, we)
        {
            taste= tas;
        }
    }
}
