using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class School
    {
        private List<ClassOfStudents> classes;

        internal List<ClassOfStudents> Classes
        {
            get { return classes; }
            set { classes = value; }
        }

        public School()
        {
            this.classes = new List<ClassOfStudents>();
        }
        public School(params ClassOfStudents[] classes)
        {
            this.classes = new List<ClassOfStudents>();
            this.classes.AddRange(classes);
        }

        public void AddClass(ClassOfStudents studentsClass)
        {
            this.classes.Add(studentsClass);
        }
        public void RemoveClass(ClassOfStudents studentsClass)
        {
            this.classes.Remove(studentsClass);
        }
    }
}
