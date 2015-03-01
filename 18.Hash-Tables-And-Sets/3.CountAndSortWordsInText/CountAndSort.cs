using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _3.CountAndSortWordsInText
{
    class CountAndSort
    {
        static void Main(string[] args)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("EN-gb");

            string path = "words.txt";
            Dictionary<string, int> counters = CountWords(path);

            var orderedCounters = counters.OrderBy(x => x.Value);

            foreach (var item in orderedCounters)
            {
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }

            Console.ReadLine();
        }

        private static Dictionary<string, int> CountWords(string path)
        {
            WordsEqualityComparer comparer = new WordsEqualityComparer();

            Dictionary<string, int> counters = new Dictionary<string,int>(comparer);
            
            StreamReader readFile = new StreamReader(path);
            using (readFile)
            {
                string line = readFile.ReadLine();
                while (line!=null)
                {
                    string[] separatedWords = line.Split
                        (new char[]{' ', '.', ',', ';', '!','?', '-', '\r','\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in separatedWords)
                    {                        
                        if (counters.ContainsKey(item))
                        {
                            counters[item]++;
                        }
                        else
                        {
                            counters.Add(item, 1);
                        }
                    }

                    line = readFile.ReadLine();
                }
            }

            return counters;
        }

        private class WordsEqualityComparer : IEqualityComparer<string>
        {

            public bool Equals(string x, string y)
            {
                if (String.Compare(x, y,true) == 0) return true;
                return false;
            }

            public int GetHashCode(string obj)
            {
                return obj.ToLower().GetHashCode();
            }            
        }
    }
}
