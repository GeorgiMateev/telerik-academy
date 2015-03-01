using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _18.ExtractEmails
{
    class Extract_Emails
    {
        public static string[] ExtractEmails(string text)
        {
            string pattern = @"\b(?<email>[^ ]*[@][a-zA-Z.]*[.][a-zA-Z]*\b)";
            MatchCollection matches = Regex.Matches(text, pattern);
            List<string> emails = new List<string>();
            foreach (var item in matches)
            {
                Match match = (Match)item;
                emails.Add(match.Groups["email"].Value);
            }
            return emails.ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            string[] emails = ExtractEmails(text);
            foreach (var item in emails)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The e-mails are not checked for incorrect symbols!");

            Console.ReadKey();
        }
    }
}
