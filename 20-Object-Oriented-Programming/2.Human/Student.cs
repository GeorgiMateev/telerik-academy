using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Human
{
    class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} Grade: {2}", this.FirstName, this.LastName, this.grade);
        }
    }
}
