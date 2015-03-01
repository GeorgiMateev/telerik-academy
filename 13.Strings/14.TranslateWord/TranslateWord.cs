using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.TranslateWord
{
    class Translate_Word
    {
        public static string TranslateWord(string dictionary, string word)
        {
            string pattern = "(.\\b" + word + "\\b) - ([^\\r]*)";
            System.Text.RegularExpressions.MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(dictionary,pattern);
            if (matches.Count==0)
            {
                return "Nothing found.";
            }
            else
            {
                return matches[0].Groups[0].Value;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
