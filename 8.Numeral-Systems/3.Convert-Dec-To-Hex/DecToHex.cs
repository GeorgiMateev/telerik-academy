using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Convert_Dec_To_Hex
{
    

    class DecToHex
    {
        private static IEnumerable<char> ConvertDecToHex(int number)
        {
            Dictionary<int, char> hexSigns = new Dictionary<int, char>();
            hexSigns.Add(10, 'A');
            hexSigns.Add(11, 'B');
            hexSigns.Add(12, 'C');
            hexSigns.Add(13, 'D');
            hexSigns.Add(14, 'E');
            hexSigns.Add(15, 'F');

            StringBuilder hex = new StringBuilder();
            while (number != 0)
            {
                int reminder = number % 16;
                if (reminder>=10)
                {
                    hex.Append(hexSigns[reminder]);
                }
                else
                {
                    hex.Append(reminder);
                }
                number /= 16;
            }
            string hexResultRev = hex.ToString();
            var hexResult = hexResultRev.Reverse();
            return hexResult;
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

            var hex = ConvertDecToHex(n);

            foreach (var item in hex)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
