using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.ReplaceForbiddenWords
{
    class ForbiddenWords
    {
        public static string ReplaceForbiddenWords(string text, string[] words, char symbol)
        {
            StringBuilder pattern = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (i<words.Length-1)
                {
                    string wordPattern = "(\\b" + words[i] + "\\b)|";
                    pattern.Append(wordPattern);
                }
                else
                {
                    string wordPattern = "(\\b" + words[i] + "\\b)";
                    pattern.Append(wordPattern);
                }
            }
            string replaced = System.Text.RegularExpressions.Regex.Replace
                (text, pattern.ToString(), m => new String(symbol,m.Length));
            return replaced;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            int n = 0;
            while (true)
            {
                Console.Write("Number of word: ");                
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        throw new ArgumentException("Enter positive number.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller number.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("Enter words:");
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            string replaced = ReplaceForbiddenWords(text, words, '*');

            Console.WriteLine(replaced);

            Console.ReadKey();
        }
    }
}
