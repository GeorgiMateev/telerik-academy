using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.SplitURL
{
    class Program
    {
        public static string[] SplitURL(string url)
        {            
            string[] parts = url.Split(new char[]{'/'}, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length<2)
            {
                throw new FormatException("Invalid url!");   
            }
            StringBuilder resourcesStr = new StringBuilder();
            resourcesStr.Append('/');
            for (int i = 2; i < parts.Length; i++)
            {
                if (i<parts.Length-1)
                {
                    resourcesStr.Append(parts[i] + '/');
                }
                else
                {
                    resourcesStr.Append(parts[i]);
                }
            }
            return new string[] {parts[0].Remove(parts[0].Length-1),parts[1],resourcesStr.ToString() };
        }

        static void Main(string[] args)
        {
           
        }
    }
}
