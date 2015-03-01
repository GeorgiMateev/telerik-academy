using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _4.CompareFiles
{
    class CompareFiles
    {
        static void Main(string[] args)
        {
            StreamReader file1 = new StreamReader(@"..\..\..\TestFile.txt");
            StreamReader file2 = new StreamReader(@"..\..\..\Second Test File.txt");

            int equal = 0;
            int notEqual = 0;

            using (file1)
            {
                using (file2)
                {
                    string line1 = file1.ReadLine();
                    string line2 = file2.ReadLine();

                    while (line1!=null)
                    {
                        
                        if (line2==line1)
                        {
                            equal++;
                        }
                        else
                        {
                            notEqual++;
                        }
                        line1 = file1.ReadLine();
                        line2 = file2.ReadLine();
                    }
                }
            }

            Console.WriteLine("Equal - {0} lines",equal);
            Console.WriteLine("Not equal - {0} lines",notEqual);

            Console.ReadKey();
        }
    }
}
