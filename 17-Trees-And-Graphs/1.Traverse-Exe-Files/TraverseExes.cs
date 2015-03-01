using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _1.Traverse_Exe_Files
{
    public static class TraverseExes
    {
        static public void DFSTraverse(DirectoryInfo dir)
        {

            List<DirectoryInfo> children = new List<DirectoryInfo>();
            try
            {
                children = dir.GetDirectories().ToList();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine(dir.FullName + " - Access denied!");
                return;
            }

            FileInfo[] files = dir.GetFiles();
            foreach (var item in files)
            {
                if (item.Extension == ".exe")
                {
                    Console.WriteLine(item.FullName);
                }
            }

            foreach (var item in children)
            {
                DFSTraverse(item);
            }
        }

        static void Main(string[] args)
        {
            DFSTraverse(new DirectoryInfo(@"C:\Windows"));

            Console.ReadKey();
        }
    }
}
