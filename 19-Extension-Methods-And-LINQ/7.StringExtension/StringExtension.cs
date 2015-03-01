using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _7.StringExtension
{
    static class StringExtension
    {
        public static string FirstLetterCapitalizer(this string str)
        {
            string[] words = str.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder capitalized = new StringBuilder(str.Length);
            TextInfo textProcessor = new CultureInfo("en-US",true).TextInfo;

            for(int i =0; i<words.Length;i++)
            {
                string firstL = textProcessor.ToTitleCase(words[i][0].ToString());
                StringBuilder word = new StringBuilder(firstL);
                for (int j = 1; j <= words[i].Length-1; j++)
                {
                    word.Append(words[i][j]);
                }

                if (i == words.Length - 1)
                {
                    capitalized.Append(word.ToString());
                }
                else
                {
                    capitalized.Append(word.ToString() + " ");
                }
            }

            return capitalized.ToString();
        }

        static void Main(string[] args)
        {
            string sampleText = "every first-letter, of a word in this   text should be capitalized!";
            string result = sampleText.FirstLetterCapitalizer();

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
