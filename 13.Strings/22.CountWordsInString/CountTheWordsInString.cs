using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22.CountWordsInString
{
    class CountTheWordsInString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            string[] words = text.Split
                (new char[]{' ', ',', '.', '(', ')', '[', ']', '{', '}', ';', ':', '-', '!', '?', '/'},
                StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (wordsCount.ContainsKey(words[i]))
                {
                    wordsCount[words[i]]++;
                }
                else
                {
                    wordsCount.Add(words[i], 1);
                }
            }

            foreach (var item in wordsCount)
            {
                Console.WriteLine("{0} - {1}",item.Key,item.Value);
            }

            Console.ReadKey();
        }
    }
}
