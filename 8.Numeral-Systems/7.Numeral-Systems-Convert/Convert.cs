using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Numeral_Systems_Convert
{
    class Convert
    {
        static char[] NumeralSystemsConvert(string number, int fromBase,  int toBase)
        {
            if (fromBase<2 || fromBase >16)
            {
                throw new ArgumentOutOfRangeException("First base shuld be between 2 and 16!");
            }
            if (toBase>16 || toBase <2)
            {
                throw new ArgumentOutOfRangeException("Second base should be between 2 and 16!");
            }

            Dictionary<char, int> hexToDecSigns = new Dictionary<char, int>()
                {
                    {'A',10},
                    {'B',11},
                    {'C',12},
                    {'D',13},
                    {'E',14},
                    {'F',15},
                };
            int decNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;
                bool isCorrectParse = int.TryParse(number[number.Length-1-i].ToString(), out digit);
                if (!isCorrectParse)
	            {
                    try
                    {
                        digit = hexToDecSigns[number[i]];
                    }
                    catch (KeyNotFoundException e)
                    {
                        throw new ArgumentException("The number is not in correct numeral system!",e);
                    }
	            }
                if (digit<0 || digit>=fromBase)
                {
                    throw new ArgumentException("The number is not in correct numeral system!");
                }
                decNumber += (int)(digit*Math.Pow(fromBase,i));
            }

            Dictionary<int, char> decToHexSigns = new Dictionary<int, char>()
                {
                    {10, 'A'},
                    {11, 'B'},
                    {12, 'C'},
                    {13, 'D'},
                    {14, 'E'},
                    {15, 'F'},
                };
            StringBuilder convertedRev = new StringBuilder();
            while (decNumber!=0)
            {
                int reminder = decNumber % toBase;
                if (reminder<=9)
                {
                    convertedRev.Append(reminder.ToString());
                }
                else
                {
                    convertedRev.Append(decToHexSigns[reminder]);
                }
                decNumber /= toBase;
            }
            string convertedStr = convertedRev.ToString();
            IEnumerable<char> converted = convertedStr.Reverse();
            return converted.ToArray();
        }

        static void Main(string[] args)
        {
            Console.Write("From base: ");
            int fromBase = int.Parse(Console.ReadLine());

            Console.Write("To base: ");
            int toBase = int.Parse(Console.ReadLine());

            Console.Write("Number = ");
            string number = Console.ReadLine();

            char[] convertedNumber = new char[100];
            try
            {
                convertedNumber = NumeralSystemsConvert(number, fromBase, toBase);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var item in convertedNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.ReadKey(true);
        }
    }
}
