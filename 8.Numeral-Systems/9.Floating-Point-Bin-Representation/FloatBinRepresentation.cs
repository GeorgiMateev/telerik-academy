using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.Floating_Point_Bin_Representation
{
    static class FloatBinRepresentation
    {
        public static byte[] GetFloatBinRepresentation(float number)
        {
            if (number==0)
            {
                return new byte[32];
            }

            byte[] sign = new byte[1];
            if (number<0)
            {
                sign[0] = 1;
            }
            else
            {
                sign[0] = 0;
            }


            
            int integerPart = Math.Abs((int)number);
            List<byte> binIntegerPart = ConvertDecToBinary(integerPart);

            float fractionPart = Math.Abs(number) - integerPart;
            List<byte> binFractionPart = ConvertFractionToBin(fractionPart);
            

            int exponent = 0;
            if (binIntegerPart.Count == 1)
            {
                if (binIntegerPart[0] != 0)
                {
                    exponent = 0;
                }
                else
                {
                    exponent = FindExponent(binFractionPart);
                    ExchangeBetweenParts(binIntegerPart, binFractionPart, exponent);
                }
            }
            else
            {
                exponent = binIntegerPart.Count - 1;
                ExchangeBetweenParts(binIntegerPart, binFractionPart, exponent);
            }

            byte[] mantissa = new byte[23];
            binFractionPart.CopyTo(mantissa, 0);

            byte[] binExponent = (ConvertDecToBinary(127 + exponent)).ToArray();

            IEnumerable<byte> floatRepresentation = sign.Concat(binExponent);
            floatRepresentation = floatRepresentation.Concat(mantissa);

            return floatRepresentation.ToArray();
        }

        private static int FindExponent(List<byte> binFractionPart)
        {
            int exponent = -1;
            int counter = 0;
            while (binFractionPart[counter] == 0)
            {
                exponent--;
                counter++;
            }
            return exponent;
        }

        private static List<byte> ConvertFractionToBin(float fractionPart)
        {
            List<byte> binFraction = new List<byte>();
            while (fractionPart != 0 && binFraction.Count < 23)
            {
                byte binDigit = (byte)(fractionPart * 2);
                binFraction.Add(binDigit);

                fractionPart *= 2;
                fractionPart -= binDigit;
            }
            return binFraction;
        }
        
        private static void ExchangeBetweenParts(List<byte> binIntPart, List<byte> binFractPart, int exponent)
        {
            if (exponent < 0)
            {
                List<byte> range = binFractPart.GetRange(0, Math.Abs(exponent) - 1);
                binIntPart.AddRange(range);
                binFractPart.RemoveRange(0,Math.Abs(exponent)-1);
            }
            if (exponent > 0)
            {
                List<byte> range = binIntPart.GetRange(1, binIntPart.Count - 1);
                binFractPart.InsertRange(0, range);
                binIntPart.RemoveRange(1, binIntPart.Count - 1);
            }
        }

        private static List<byte> ConvertDecToBinary(int number)
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
    }

    class GetBinRepresentationProgram
    {
        static void Main(string[] args)
        {
           

            float number = float.Parse(Console.ReadLine());
            byte[] binaryNumber = FloatBinRepresentation.GetFloatBinRepresentation(number);

            foreach (var item in binaryNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }

}
