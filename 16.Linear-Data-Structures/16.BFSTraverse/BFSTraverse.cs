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
        /// Traverses and prints the directories inside the given one using BFS.
        /// </summary>
        /// <param name="dirPath">The directory to be traversed.</param>
        public static void BFSTraverseDirectories(string dirPath)
        {
            Queue<DirectoryInfo> visited = new Queue<DirectoryInfo>();
            visited.Enqueue(new DirectoryInfo(dirPath));

            while (visited.Count>0)
            {
                DirectoryInfo currentDirectory = visited.Dequeue();
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
                    visited.Enqueue(item);
                }
            }
        }

        static void Main(string[] args)
        {
            BFSTraverseDirectories("C:\\");

            Console.ReadKey();
        }
    }
}
