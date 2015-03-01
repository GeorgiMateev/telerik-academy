using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.ReplaceUpCaseTags
{
    class UpCaseTags
    {
        public static string ReplaceUpperCaseTags(string str)
        {
            System.Text.RegularExpressions.MatchCollection strToReplace= System.Text.RegularExpressions.Regex.Matches
                (str, "\\<upcase\\>([a-z ]+)\\</upcase\\>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            if (strToReplace.Count==0)
            {
                return str;
            }

            int targetIndex = strToReplace[0].Groups[0].Index;
            StringBuilder replacedString = new StringBuilder();
            for (int i = 0, item = 0; i < str.Length; i++)
            {
                if (i<targetIndex)
                {
                    replacedString.Append(str[i]);
                }
                else
                {
                    string upCaseStr = strToReplace[item].Groups[1].Value.ToUpper();
                    replacedString.Append(upCaseStr);
                    i += strToReplace[item].Groups[0].Length-1;
                    item++;
                    if (item == strToReplace.Count)
                    {
                        targetIndex = str.Length;
                    }
                    else
                    {
                        targetIndex = strToReplace[item].Groups[0].Index;
                    }
                }                
            }
            return replacedString.ToString();

            //With many items to replace it will create a lot of long strings
            //string replacedString = str;
            //for (int i = 0; i < strToReplace.Count; i++)
            //{
            //    string upCase = strToReplace[i].Groups[1].Value.ToUpper();
            //    replacedString = System.Text.RegularExpressions.Regex.Replace
            //        (replacedString, strToReplace[i].Groups[0].Value, upCase, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            //}
            //return replacedString;
        }

        static void Main(string[] args)
        {
            string str = @"We are living in a <upcase>submarine</upcase> . We don't have <upcase>anything</upcase> else.";            

            Console.WriteLine(ReplaceUpperCaseTags(str));

            Console.ReadKey();
        }
    }
}
