using Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28_template
{
    internal class Refrigerator : Thing
    {
        public float _prince;
        public float Prince
        {
            get { return _prince; }
        }
        public Refrigerator(float prince, string n, float w, float h, float d, float we) : base(n, w, h, d, we)
        {
            _prince = prince;
        }
    }
}
