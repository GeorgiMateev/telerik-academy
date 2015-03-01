using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.File_Folder_Tree
{
    class SampleTree
    {
        public static void Main()
        {
            FileFolderTree tree = new FileFolderTree("C:\\Windows");

            long size = tree.CalculateFilesSizesDFS(tree.RootFolder, "C:\\Windows", false);

            Console.WriteLine(size);

            Console.ReadKey();
        }
        
    }
}
