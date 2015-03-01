using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.IndexInAlphabet
{
    class IndexInAlphabet
    {
        static int BinarySearch(char[] numbers, char s)
        {
            int left = 0;
            int right = numbers.Length - 1;

            if (s == numbers[right])
            {
                return right;
            }

            int position = 0;

            int mid = (left + right) / 2;
            do
            {
                if (s == numbers[mid])
                {
                    return mid;
                }
                if (s < numbers[mid])
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
                mid = (left + right) / 2;
            } while (mid != left && mid != right);
            position = mid * -1;
            return position;
        }

        static void Main(string[] args)
        {
            char[] alphabet = new char[52];

            for (int i = 0; i <= 25; i++)
            {
                alphabet[i] = (char)(65 + i);
            }
            for (int i = 26; i <= 51; i++)
            {
                alphabet[i] = (char)(97 + i - 26);
            }

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            foreach (var item in word)
            {
                int index = BinarySearch(alphabet, item);
                Console.Write("{0} ", index);
            }

            Console.ReadKey();
        }
    }
}
