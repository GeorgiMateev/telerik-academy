using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _25.ExtractTitleAndBody
{
    class ExtractTitleAndBody
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter HTML page:");
            string html = "<html><head><title>News gosho</title></head><body><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</body></html>";

            string patterTitle = @"\<title\>(?<title>.*)\</title\>";
            string patternBody = @"\<body\>(?<body>.*)\</body\>";

            Match matchTitle = Regex.Match(html, patterTitle);
            string title = matchTitle.Groups["title"].Value;

            Match matchBody = Regex.Match(html, patternBody);
            string body = matchBody.Groups["body"].Value;

            Regex clearBody = new Regex(@"(\<.*\>)|(\</.*\>)");
            string clearedBody = clearBody.Replace(html, " ");

            Console.WriteLine(title);
            Console.WriteLine(clearedBody);

            Console.ReadKey();
        }
    }
}
