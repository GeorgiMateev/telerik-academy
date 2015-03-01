using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GenerateBigTextFile
{
    class GenerateBigTextFile
    {
        const string FILE_PATH = @"..\..\..\BigTextFile.txt";

        static void Main(string[] args)
        {
            Console.Write("Size of the file in MB: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("String to repeatly write: ");
            string str = Console.ReadLine();

            StreamWriter file = new StreamWriter(FILE_PATH,false);
            using (file)
            {
                FileInfo info = new FileInfo(FILE_PATH);
                do
                {
                    file.WriteLine(str);
                    info = new FileInfo(FILE_PATH);
                }
                while (info.Length / 1000000 < size);
            }
        }
    }
}
