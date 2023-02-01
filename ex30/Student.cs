using Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28_template
{
    internal class Student : Person
    {
        public string id;
        public string ID
        {
            get { return id; }
        }
        public Student(string i, DateTime bd, string n, float w, float h, float d, float we) : base (bd, n, w, h, d, we)
        {
            id = i;
        }
    }
}
