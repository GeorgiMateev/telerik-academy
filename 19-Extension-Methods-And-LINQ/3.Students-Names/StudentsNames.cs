using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Students_Names
{
    class Students
    {
        
        static void Main(string[] args)
        {
            var students = new[] 
            { new { f = "Pesho", l = "Peshev", a=13}, new { f = "Gosho", l = "Goshev", a=45},
                new { f = "Anton", l = "Tonev", a=20}, new { f = "Tsetan", l = "Angelov", a=24} };

            var lexNames =
                from student in students
                where student.f.CompareTo(student.l) < 0
                select student;

            Console.WriteLine("First name lexicographicaly before last name:");
            foreach (var item in lexNames)
            {
                Console.WriteLine(item.f+" "+item.l);
            }
            Console.WriteLine();

            var age =
                from student in students
                where student.a <= 24 && student.a >= 18
                select student;

            Console.WriteLine("Age between 18 and 24:");
            foreach (var item in age)
            {
                Console.WriteLine(item.f + " " + item.l+" "+item.a);
            }
            Console.WriteLine();

            var sorted = students.OrderByDescending(x => x.f).ThenByDescending(x => x.l);

            Console.WriteLine("Sorted by first and last name descending: ");
            foreach (var item in sorted)
            {
                Console.WriteLine(item.f + " " + item.l+" "+item.a);
            }

            Console.ReadKey();
        }
    }
}
