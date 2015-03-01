using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, "Female")
        {
        }
    }
}
