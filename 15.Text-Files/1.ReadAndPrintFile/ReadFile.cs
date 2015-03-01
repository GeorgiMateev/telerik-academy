using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _1.ReadAndPrintFile
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\TestFile.txt";
            StreamReader read = new StreamReader(filePath);

            using (read)
            {
                for (int i = 1; ; i++)
                {

                    if (i % 2 != 0)
                    {
                        Console.WriteLine(read.ReadLine());
                    }
                    else
                    {
                        read.ReadLine();
                    }

                    if (read.EndOfStream)
                    {
                        break;
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
