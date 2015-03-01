using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class ClassOfStudents
    {
        private List<Teacher> teachers;

        internal List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        private List<Student> students;

        internal List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public ClassOfStudents(string id)
        {
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
            this.id = id;
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.AddTeacher(teacher);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }
    }
}
