using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.SumTheNumbersInString
{
    public class SumTheNumbersInString
    {
        public static int SumNumbersInString(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length;)
            {
                StringBuilder numberString = new StringBuilder();
                while (i < str.Length && str[i] != ' ')
                {
                    numberString.Append(str[i]);
                    i++;
                }
                int number = int.Parse(numberString.ToString());
                sum += number;
                i++;
            }
            return sum;
        }

        static void Main(string[] args)
        {
        }
    }
}
