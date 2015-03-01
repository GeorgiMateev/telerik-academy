using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.ExtractSentences
{
    class ExtractSentences
    {
        public static string[] ExtractSentencesByWord(string text, string word)
        {
            string pattern = "\\b"+word+"\\b";
            string[] sentences = text.Split(new string[]{"."}, StringSplitOptions.RemoveEmptyEntries);
            List<string> sentencesWithWord = new List<string>();
            foreach (var item in sentences)
            {
                bool containsWord = System.Text.RegularExpressions.Regex.IsMatch
                    (item,pattern,System.Text.RegularExpressions.RegexOptions.CultureInvariant);
                if (containsWord)
                {
                    string s = item + ".";                 
                    sentencesWithWord.Add(s);
                }
            }

            return sentencesWithWord.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            string[] sentences = ExtractSentencesByWord(text, word);

            foreach (var item in sentences)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
