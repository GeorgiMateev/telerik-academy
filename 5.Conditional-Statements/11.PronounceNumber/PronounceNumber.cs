using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.PronounceNumber
{
    public struct UniqueNumbers
    {
       
        public static Dictionary<int, string> uniqueNumbers = new Dictionary<int, string>()
            {
                { 0, "zero"},
                { 1, "one"},
                { 2, "two"},
                { 3, "three"},
                { 4, "four"},
                { 5, "five"},
                { 6, "six"},
                { 7, "seven"},
                { 8, "eight"},
                { 9, "nine"},
                { 10, "ten"},
                { 11, "eleven"},
                { 12, "twelve"},
                { 13, "thirteen"},
                { 15, "fifteen"},
                { 20, "twenty"},
                { 30, "thirty"},
                { 50, "fifty"},
            };
    
    }

    class PronounceNumber
    {
        static void Main(string[] args)
        {
            

            int n = 0;
            bool isCorrectInput = false;
            do
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (!(n >= 0 && n <= 999))
                    {
                        throw new ArgumentOutOfRangeException("Enter number between 0 and 999!");
                    }
                    isCorrectInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer number!");
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            while (!isCorrectInput);

            string pron = GetNumberPronunciation(UniqueNumbers.uniqueNumbers, n);

            Console.WriteLine(pron);

            Console.ReadKey(false);
        }

        private static string GetNumberPronunciation(Dictionary<int,string> uniqueNumbers, int n)
        {
            int firstDigit = n / 100;
            n %= 100;
            int tens = n - n % 10;
            int secondDigit = n / 10;
            int thirdDigit = n % 10;

            string pronunciation = null;

            bool isUniqueTensNumber =
                uniqueNumbers.FirstOrDefault(x => x.Key == tens).Value != default(KeyValuePair<int, string>).Value;
            bool isOneDigit = firstDigit == 0 && secondDigit == 0;
            bool isRoundTens = thirdDigit == 0;
            bool isNormalTens = !isUniqueTensNumber && !isRoundTens;

            if (isOneDigit)
            {
                pronunciation = uniqueNumbers[thirdDigit];
            }
            if (isNormalTens)
            {
                pronunciation = uniqueNumbers[secondDigit] + "ty" + " " + uniqueNumbers[thirdDigit];
            }
            if (isRoundTens)
            {
                pronunciation = uniqueNumbers[secondDigit] + "ty";
            }
            if (isUniqueTensNumber)
            {
                pronunciation = uniqueNumbers[tens]+" "+uniqueNumbers[thirdDigit];
            }

            if (firstDigit!=0 && secondDigit==0 && thirdDigit==0)
            {
                return uniqueNumbers[firstDigit] + " hundred";
            }
            if (firstDigit != 0)
            {
                string finalPron = uniqueNumbers[firstDigit] + " hundred and " + pronunciation;
                return finalPron;
            }
            else
            {
                return pronunciation;
            }
            
        }
    }
}
