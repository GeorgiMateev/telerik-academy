using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _3.InsertLineNumbers
{
    class InsertLineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"..\..\..\Concatenate first and second.txt");
            StreamWriter fileToWrite = new StreamWriter(@"..\..\..\ConcatenateWithLineNumbers.txt");
            using (file)
            {
                using (fileToWrite)
                {
                    
                    int number = 1;
                    string line = file.ReadLine();
                    while (line != null)
                    {
                        line = file.ReadLine();
                        string formated = string.Format("{0,3} {1}", number, line);
                        number++;
                        fileToWrite.WriteLine(formated);
                    }
                }
            }
        }
    }
}
