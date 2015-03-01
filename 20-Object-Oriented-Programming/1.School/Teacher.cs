using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class Teacher : Human
    {
        private List<Discipline> disciplines;

        internal List<Discipline> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }

        public Teacher(string name)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string name, params Discipline[] disciplines)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
            this.disciplines.AddRange(disciplines);
        }
    }
}
