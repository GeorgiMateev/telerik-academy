using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Convert_Hex_To_Dec
{
    class Program
    {
        static int ConvertHexToDec(List<char> hex)
        {
            Dictionary<char, int> hexSigns = new Dictionary<char, int>()
                {
                    {'A',10},
                    {'B',11},
                    {'C',12},
                    {'D',13},
                    {'E',14},
                    {'F',15},
                    {'0',0},
                    {'1',1},
                    {'2',2},
                    {'3',3},
                    {'4',4},
                    {'5',5},
                    {'6',6},
                    {'7',7},
                    {'8',8},
                    {'9',9},
                };
            
            double dec = 0;
            for (int i = 0; i < hex.Count; i++)
            {
                dec += hexSigns[ hex[hex.Count - 1 - i] ] * Math.Pow(16.0, i);                 
            }
            return (int)dec;
        }
        static void Main(string[] args)
        {
            string hexS = Console.ReadLine();
            List<char> hex = new List<char>();
            foreach (var item in hexS)
            {
                hex.Add(item);
            }
            int dec = ConvertHexToDec(hex);

            Console.WriteLine(dec);

            Console.ReadKey();
        }
    }
}
