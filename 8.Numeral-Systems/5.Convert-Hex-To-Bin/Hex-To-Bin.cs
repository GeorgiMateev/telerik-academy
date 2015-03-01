using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Convert_Hex_To_Bin
{
    class Program
    {
        static IEnumerable<byte> ConvertHexToBin(string hexNumber)
        {
            Dictionary<char, byte[]> tableOfBits = new Dictionary<char, byte[]>()
                {
                    {'0', new byte[]{0,0,0,0} },
                    {'1', new byte[]{0,0,0,1} },
                    {'2', new byte[]{0,0,1,0} },
                    {'3', new byte[]{0,0,1,1} },
                    {'4', new byte[]{0,1,0,0} },
                    {'5', new byte[]{0,1,0,1} },
                    {'6', new byte[]{0,1,1,0} },
                    {'7', new byte[]{0,1,1,1} },
                    {'8', new byte[]{1,0,0,0} },
                    {'9', new byte[]{1,0,0,1} },
                    {'A', new byte[]{1,0,1,0} },
                    {'B', new byte[]{1,0,1,1} },
                    {'C', new byte[]{1,1,0,0} },
                    {'D', new byte[]{1,1,0,1} },
                    {'E', new byte[]{1,1,1,0} },
                    {'F', new byte[]{1,1,1,1} },
                };
            IEnumerable<byte> bin = new byte[0];
            foreach (var item in hexNumber)
            {
                bin = bin.Concat(tableOfBits[item]);
            }
            return bin;
        }

        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            var bin = ConvertHexToBin(hex);

            foreach (var item in bin)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
