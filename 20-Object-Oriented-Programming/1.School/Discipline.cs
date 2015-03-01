using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class Discipline
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int lecturesCount;
        public int LecturesCount
        {
            get { return lecturesCount; }
            set { lecturesCount = value; }
        }

        private int studentsCount;
        public int StudentsCount
        {
            get { return studentsCount; }
            set { studentsCount = value; }
        }

        public Discipline(string name, int lectures, int students)
        {
            this.name = name;
            this.lecturesCount = lectures;
            this.studentsCount = students;
        }
    }
}
