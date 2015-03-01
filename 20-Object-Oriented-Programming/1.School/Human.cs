using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    abstract class Human
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Human(string name)
        {
            this.name = name;
        }
    }
}
