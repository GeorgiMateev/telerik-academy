using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.Binary_Representation
{
    class Program
    {
        static byte[] GetBinaryRepresentation(short number)
        {
            byte[] representation = new byte[16];
            if (number==0)
            {
                return representation;
            }
            if (number < 0)
            {
                representation[0] = 1;
            }
            else
            {
                representation[0] = 0;
            }
            for (int i = 0; i < 15; i++)
            {
                short mask = 1;
                mask <<= i;
                short bit = (short)(number & mask);
                bit >>= i;
                representation[15 - i] = (byte)bit;
            }
            return representation;
        }
        static void Main(string[] args)
        {
            short n = 0;
            bool iscorrect = false;
            while (!iscorrect)
            {
                Console.Write("(short)n = ");
                iscorrect = short.TryParse(Console.ReadLine(),out n);
            }

            byte[] repr = GetBinaryRepresentation(n);

            foreach (var item in repr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
