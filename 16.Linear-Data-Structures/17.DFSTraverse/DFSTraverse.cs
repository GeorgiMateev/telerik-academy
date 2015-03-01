using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _16.BFSTraverse
{
    class BFSTraverse
    {
        /// <summary>
        /// Traverses and prints the directories inside the given one using DFS implemented with stack.
        /// </summary>
        /// <param name="dirPath">The directory to be traversed.</param>
        public static void DFSTraverseDirectories(string dirPath)
        {
            Stack<DirectoryInfo> visited = new Stack<DirectoryInfo>();
            visited.Push(new DirectoryInfo(dirPath));

            while (visited.Count > 0)
            {
                DirectoryInfo currentDirectory = visited.Pop();
                Console.WriteLine(currentDirectory.FullName);

                List<DirectoryInfo> children = new List<DirectoryInfo>();
                try
                {
                    children = currentDirectory.GetDirectories().ToList();
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine(" - Access denied!");
                }

                foreach (var item in children)
                {
                    visited.Push(item);
                }
            }
        }

        static void Main(string[] args)
        {
            DFSTraverseDirectories("C:\\");

            Console.ReadKey();
        }
    }
}
