using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Wintellect.PowerCollections;

namespace _1.Courses_With_Students
{
    class SortedCourses
    {
        static void Main(string[] args)
        {
            string filePath = "students.txt";

            SortedDictionary<string, OrderedMultiDictionary<string, string>> coursesWithStudents =
                new SortedDictionary<string,OrderedMultiDictionary<string,string>>();
             

            StreamReader fileReader = new StreamReader(filePath);
            using (fileReader)
            {
                string line = fileReader.ReadLine();
                while (line != null)
                {
                    string[] lineParts = line.Split('|');

                    string course = lineParts[2].Trim();
                    string firstname = lineParts[0].Trim();
                    string lastName = lineParts[1].Trim();

                    if (coursesWithStudents.ContainsKey(course))
                    {
                        coursesWithStudents[course].Add(lastName, firstname);
                    }
                    else
                    {
                        OrderedMultiDictionary<string,string> students = new OrderedMultiDictionary<string, string>(true);
                        students.Add(lastName, firstname);
                        coursesWithStudents.Add(course, students);                        
                    }

                    line = fileReader.ReadLine();
                }
            }

            foreach (var course in coursesWithStudents)
            {
                Console.Write("{0}: ", course.Key);
                foreach (var student in course.Value)
                {
                    foreach (var name in student.Value)
                    {
                        Console.Write("{0} {1}, ", name, student.Key);
                    }                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
