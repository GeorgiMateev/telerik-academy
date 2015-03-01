using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LastNumber
{
    class LastDigit
    {
        static string GetLastDigitAsWord(int number)
        {
            Dictionary<byte, string> digits = new Dictionary<byte, string>()
            {
                {0,"zero"},
                {1,"one"},
                {2,"two"},
                {3,"three"},
                {4,"four"},
                {5,"five"},
                {6,"six"},
                {7,"seven"},
                {8,"eight"},
                {9,"nine"},
            };
            byte digit = (byte)(number % 10);
            return digits[digit];            
        }

        static void Main(string[] args)
        {
            bool isCorrect = false;
            int n = 0;
            while (!isCorrect)
            {
                Console.Write("n = ");
                isCorrect = int.TryParse(Console.ReadLine(), out n);
            }

            string word = GetLastDigitAsWord(n);
            Console.WriteLine(word);

            Console.ReadKey();
        }
    }
}
