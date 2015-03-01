using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23.CompressString
{
    class CompressString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string text = Console.ReadLine();

            StringBuilder compressed = new StringBuilder();
            char currentChar = text[0];
            for (int i = 0; i < text.Length; i++)
            {
                currentChar = text[i];
                if (i==text.Length-1)
                {
                    compressed.Append(currentChar); continue;
                }
                if (text[i]==text[i+1])
                {
                    continue;
                }
                else
                {
                    compressed.Append(currentChar);
                }
            }

            Console.WriteLine(compressed.ToString());

            Console.ReadKey();
        }
    }
}
