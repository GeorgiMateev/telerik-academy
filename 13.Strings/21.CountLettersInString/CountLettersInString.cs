using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21.CountLettersInString
{
    class CountLettersInString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            Dictionary<string, int> letters = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                bool isLetter = Char.IsLetter(text[i]);
                if (isLetter)
                {
                    if (letters.ContainsKey(text[i].ToString()))
                    {
                        letters[text[i].ToString()]++;
                    }
                    else
                    {
                        letters.Add(text[i].ToString(), 1);
                    }
                }
            }

            foreach (var item in letters)
            {
                Console.WriteLine("{0} - {1}",item.Key,item.Value);
            }

            Console.ReadKey();
        }
    }
}
