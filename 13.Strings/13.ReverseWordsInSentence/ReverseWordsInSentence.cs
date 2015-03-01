using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.ReverseWordsInSentence
{
    class ReverseWordsInSentence
    {
        public static string ReverseWords(string str)
        {
            char punctMark = str[str.Length - 1];
            string[] words = str.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            words[words.Length-1] = words[words.Length - 1].Remove(words[words.Length - 1].Length - 1);
            List<string> wordsList = words.ToList();

            for (int i = 0; i < wordsList.Count; i++)
            {
                char punct = wordsList[i].FirstOrDefault(x => x == ',' || x == ';' || x == ':' || x == '-');
                if (punct!=default(char))
                {
                    wordsList.Insert(i+1, punct.ToString());
                    wordsList[i] = wordsList[i].Remove(wordsList[i].Length - 1);
                    i++;
                }
            }

            wordsList.Reverse();
            StringBuilder revStr = new StringBuilder();
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (i < wordsList.Count - 1 
                    && wordsList[i + 1] != "," && wordsList[i + 1] != ":" 
                    && wordsList[i + 1] != ";" && wordsList[i + 1] != "-")
                {
                    revStr.Append(wordsList[i]+" ");
                }
                else
                {
                    revStr.Append(wordsList[i]);
                }
            }
            revStr.Append(punctMark);
            return revStr.ToString();
        }
        
        static void Main(string[] args)
        {
            
        }
    }
}
