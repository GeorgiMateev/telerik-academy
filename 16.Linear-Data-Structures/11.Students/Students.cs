using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace _11.Students
{
    class Student : IComparable<Student>
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private bool paidSemesterOnline;
        public bool PaidSemesterOnline
        {
            get { return paidSemesterOnline; }
            set { paidSemesterOnline = value; }
        }

        static Student FindNext(OrderedBag<Student> queue)
        {
            return queue.GetFirst();
        }

        public Student(string name, int age, bool paidOnline)
        {
            this.name = name;
            this.age = age;
            this.paidSemesterOnline = paidOnline;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", this.name, this.age, this.paidSemesterOnline);
        }

        public int CompareTo(Student other)
        {
            if (this.PaidSemesterOnline==true && other.PaidSemesterOnline==false)
            {
                return -1;
            }
            if (this.PaidSemesterOnline==false && other.PaidSemesterOnline==true)
            {
                return 1;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            OrderedBag<Student> q = new OrderedBag<Student>();
            Student s1 = new Student("Gosho",19,false);
            Student s2 = new Student("Petio", 21, true);
            Student s3 = new Student("Tosho", 19, true);
            Student s4 = new Student("Joro", 20, false);
            Student s5 = new Student("Petkan", 35, false);

            q.Add(s1);
            q.Add(s2);
            q.Add(s3);
            q.Add(s4);
            q.Add(s5);

            for(int i = 0; q.Count>0; i++)
            {
                Student current = q.RemoveFirst();
                Console.WriteLine(current.ToString());
            }

            Console.ReadKey();
        }
    }
}
