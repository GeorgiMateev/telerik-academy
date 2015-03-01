using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _2.ConcatenateTwoFiles
{
    class Concatenate
    {
        static void Main(string[] args)
        {
            StreamReader file1 = new StreamReader(@"..\..\..\TestFile.txt");
            StreamReader file2 = new StreamReader(@"..\..\..\Second Test File.txt");

            StreamWriter concat = new StreamWriter(@"..\..\..\Concatenate first and second.txt",true);

            using (concat)
            {
                using (file1)
                {
                    concat.Write(file1.ReadToEnd());
                }
                using (file2)
                {
                    concat.Write(file2.ReadToEnd());
                }
            }
            
        }
    }
}
