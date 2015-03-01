using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class Student : Human
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Student(string name, int ID)
            : base(name)
        {
            this.id = ID;
        }
    }
}
