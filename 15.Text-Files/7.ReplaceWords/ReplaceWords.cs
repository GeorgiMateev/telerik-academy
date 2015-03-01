using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _7.ReplaceWords
{
    class Program
    {
        const string READ_FROM = @"..\..\..\BigTextFile.txt";
        const string WRITE_TO = @"..\..\..\ReplacedWords.txt";
        const string WORD_TO_REPLACE = "start";
        const string REPLACE_WITH = "finish";

        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(READ_FROM);
            StreamWriter write = new StreamWriter(WRITE_TO);

            using (read)
            {
                using (write)
                {
                    string pattern = WORD_TO_REPLACE;
                    string line;
                    while ((line=read.ReadLine()) != null)
                    {
                        string replacedLine = Regex.Replace(line, pattern, REPLACE_WITH);
                        write.WriteLine(replacedLine);
                    }
                }
            }
        }
    }
}
