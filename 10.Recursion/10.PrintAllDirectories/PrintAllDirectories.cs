using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _10.PrintAllDirectories
{
    class PrintAllDirectories
    {
        /// <summary>
        /// Prints all directories using DFS algorithm.
        /// </summary>
        /// <param name="dir">Directory to start from.</param>
        public static void PrintAllDirectoriesDFS(DirectoryInfo dir)
        {
            try
            {
                Console.WriteLine(dir.FullName);
                DirectoryInfo[] children = new DirectoryInfo[1000000];

                children = dir.GetDirectories();


                foreach (var item in children)
                {
                    PrintAllDirectoriesDFS(item);
                }
            }
            catch (UnauthorizedAccessException)
            {

            }
            catch (NullReferenceException)
            {
            }
            
        }

        static void Main(string[] args)
        {
            PrintAllDirectoriesDFS(new DirectoryInfo("C:"));

            Console.ReadKey();
        }
    }
}
