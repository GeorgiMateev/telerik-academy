using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Human
{
    abstract class Human
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public abstract string ToString();
    }
}
