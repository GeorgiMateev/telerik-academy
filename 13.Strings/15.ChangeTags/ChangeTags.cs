using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _15.ChangeTags
{
    class Change_Tags
    {
        public static string ChangeTags(string str)
        {
            string pattern1 = "\\<a href=\"(?<url>[^\"]*)\"\\>";
            string replaced1 = Regex.Replace(str,pattern1,m => "[URL="+m.Groups["url"].Value+"]");

            string pattern2 = "\\</a\\>";
            string replacement2 = "[/URL]";
            string replaced2 = Regex.Replace(replaced1, pattern2, replacement2);

            return replaced2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            string replaced = ChangeTags(text);

            Console.WriteLine(replaced);

            Console.ReadKey();
        }
    }
}
