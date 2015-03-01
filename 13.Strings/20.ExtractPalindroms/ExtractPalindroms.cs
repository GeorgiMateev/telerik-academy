using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20.ExtractPalindroms
{
    class Extract_Palindroms
    {
        public static string[] ExtractPalindroms(string text)
        {
            string[] words = text.Split(' ');
            List<string> palindroms = new List<string>();
            foreach (var item in words)
            {
                bool isPalindrom = true;
                for (int i = 0; i < item.Length / 2; i++)
                {
                    if (item[i] != item[item.Length - 1 - i])
                    {
                        isPalindrom = false; break;
                    }
                }
                if (isPalindrom)
                {
                    palindroms.Add(item);
                }
            }

            return palindroms.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            string[] palindroms = ExtractPalindroms(text);

            foreach (var item in palindroms)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
