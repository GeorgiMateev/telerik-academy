using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Convert_Bin_To_Dec
{
    class ConvertToDecimal
    {
        private static long ConvertBinToDec(long number)
        {
            double dec = 0;
            int counter = 0;
            while (number!=0)
            {
                dec += (number % 10) * Math.Pow(2.0, counter);
                number /= 10;
                counter++;
            }
            return (long)dec;
        }

        static void Main(string[] args)
        {
            bool isCorrect = false;
            long n = 0;
            while (!isCorrect)
            {
                Console.Write("n = ");
                isCorrect = long.TryParse(Console.ReadLine(), out n);
            }

            long dec = ConvertBinToDec(n);
            Console.WriteLine(dec);

            Console.ReadKey();
        }
    }
}
