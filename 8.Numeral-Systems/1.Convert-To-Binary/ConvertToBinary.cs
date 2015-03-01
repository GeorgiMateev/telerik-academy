using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Convert_To_Binary
{
    class ConvertToBinary_
    {
        private static List<byte> ConvertToBinary(int number)
        {
            List<byte> bits = new List<byte>();
            if (number == 0)
            {
                bits.Add(0);
            }
            while (number != 0)
            {
                byte bit = (byte)(number % 2);
                bits.Add(bit);
                number /= 2;
            }
            bits.Reverse();
            return bits;
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

            List<byte> bitsN = ConvertToBinary(n);

            foreach (var item in bitsN)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
