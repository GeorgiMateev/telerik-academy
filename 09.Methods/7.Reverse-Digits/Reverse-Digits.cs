using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Reverse_Digits
{
    class Program
    {
        static int ReverseNumber(int number)
        {
            StringBuilder reversed = new StringBuilder();
            while (number!=0)
            {
               int digit =  number % 10;
               reversed.Append(digit);
               number /= 10;
            }
            return int.Parse(reversed.ToString());
        }

        static void Main(string[] args)
        {
            bool isCorrectNumber = false;
            int number = 0;
            while (!isCorrectNumber)
            {
                Console.Write("number = ");
                isCorrectNumber = int.TryParse(Console.ReadLine(), out number);
            }

            int reversed = ReverseNumber(number);

            Console.WriteLine(reversed);

            Console.ReadKey();
        }
    }
}
