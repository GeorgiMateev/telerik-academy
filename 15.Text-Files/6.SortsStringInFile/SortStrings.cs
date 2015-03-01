using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _6.SortsStringInFile
{
    class SortStrings
    {
        static void Main(string[] args)
        {
            StreamReader toBeSorted = new StreamReader(@"..\..\..\TestFile.txt");
            string[] sorted;
            using (toBeSorted)
            {
                string content = toBeSorted.ReadToEnd();
                string[] lines = content.Split(new string[]{"\r\n"},StringSplitOptions.RemoveEmptyEntries);
                sorted = lines.OrderBy(x => x).ToArray();
            }

            StreamWriter writeSorted = new StreamWriter(@"..\..\..\SortedTestFile.txt");
            using (writeSorted)
            {
                foreach (var item in sorted)
                {
                    writeSorted.WriteLine(item);
                }
            }
        }
    }
}
