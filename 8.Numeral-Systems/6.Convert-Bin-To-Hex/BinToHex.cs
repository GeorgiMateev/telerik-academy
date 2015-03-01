using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.Convert_Bin_To_Hex
{
    public class BinToHex
    {
        public static string ConvertBinToHex(string number)
        {
            Dictionary<string,char[]> tableOfBits = new Dictionary<string,char[]>()
                {
                    { "0000",new char[]{'0'} },
                    { "0001",new char[]{'1'} },
                    { "0010",new char[]{'2'} },
                    { "0011",new char[]{'3'} },
                    { "0100",new char[]{'4'} },
                    { "0101",new char[]{'5'} },
                    { "0110",new char[]{'6'} },
                    { "0111",new char[]{'7'} },
                    { "1000",new char[]{'8'} },
                    { "1001",new char[]{'9'} },
                    { "1010",new char[]{'A'} },
                    { "1011",new char[]{'B'} },
                    { "1100",new char[]{'C'} },
                    { "1101",new char[]{'D'} },
                    { "1110",new char[]{'E'} },
                    { "1111",new char[]{'F'} },
                };

            string fullNumber;
            if (number.Length % 4 != 0)
            {
                string zeros = new string('0',4 - (number.Length % 4));
                fullNumber = String.Concat(zeros, number);
            }
            else
            {
                fullNumber = number;
            }


            StringBuilder hex = new StringBuilder();
            for (int i = 0; i < fullNumber.Length-3; i+=4)
            {
                StringBuilder seq = new StringBuilder();
                seq.Append(fullNumber[i]);
                seq.Append(fullNumber[i+1]);
                seq.Append(fullNumber[i+2]);
                seq.Append(fullNumber[i+3]);

                hex.Append(tableOfBits[seq.ToString()]);
            }
            return hex.ToString();
        }

        static void Main(string[] args)
        {
            string bin = Console.ReadLine();            

            string hex = ConvertBinToHex(bin);
            
            Console.WriteLine(hex);

            Console.ReadKey();
        }
    }
}
