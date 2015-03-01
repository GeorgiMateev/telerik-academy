using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Human
{
    class HumanUsage
    {
        private const int StudentsCount = 10;
        private const int WorkersCount = 10;

        public static void Main()
        {
            Student[] students = new Student[StudentsCount];
            Random randGrade = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student("Gosho" + i, "Ivanov" + i, randGrade.Next(2, 7));
            }

            var orderedStudents = students.OrderBy(x => x.Grade);

            foreach (var item in orderedStudents)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();

            Worker[] workers = new Worker[WorkersCount];
            Random rand=new Random();
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker("Todor" + i, "Toshec" + i, rand.Next(250, 1501), rand.Next(4, 9));
            }

            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var item in orderedWorkers)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
