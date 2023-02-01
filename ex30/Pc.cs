using Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28_template
{
    internal class Pc : Thing
    {
        public string production;
        public string Production
        {
            get { return production; }
        }

    public Pc(string prod , string n, float w, float h, float d, float we) : base(n, w, h, d, we)
        {
            production = prod;
        }
    }
}
