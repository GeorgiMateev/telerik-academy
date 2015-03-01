using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.StringEncoding
{
    class StringEncoding
    {
        public static string EncodeString(string str, string key)
        {
            if (str=="" || key=="")
            {
                throw new ArgumentException("The arguments can't be empty!");
            }

            int keyIndex = 0;
            StringBuilder result = new StringBuilder();
            for (int strIndex = 0; strIndex < str.Length; strIndex++)
            {                
                char symbol = (char)((int)str[strIndex] ^ (int)key[keyIndex]);
                result.Append(symbol);
                keyIndex++;
                if (keyIndex >= key.Length)
                {
                    keyIndex = 0;
                }
            }
            return result.ToString();
        }


        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter string to encode: ");
                string str = Console.ReadLine();

                Console.Write("Enter key: ");
                string key = Console.ReadLine();

                Console.Write("Encoded: ");
                string encoded = EncodeString(str, key);
                Console.WriteLine(encoded);

                Console.Write("Decoded: ");
                string decoded = EncodeString(encoded, key);
                Console.WriteLine(decoded);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
