﻿using Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28_template
{
    internal class Car : Thing
    {
        public float speed;
        public float Speed
        {
            get { return speed; }
        }
        public Car(float s, string n, float w, float h, float d, float we) : base(n, w, h, d, we)
        {
            speed= s;
        }
    }
}
