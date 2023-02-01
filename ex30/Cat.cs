using Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28_template
{
    internal class Cat : Animal
    {
        public string catBreed;
        public string CatBreed
        {
            get { return catBreed; }
        }
        public Cat(string cat, DateTime bd, string n, float w, float h, float d, float we) : base(bd, n, w, h, d, we)
        {
            catBreed= cat;
        }
    }
}
