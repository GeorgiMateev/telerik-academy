using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Animals
{
    class Frog : Animal
    {
        public Frog(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public override string MakeSound()
        {
            return "Kvak!";
        }
    }
}
