using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.Polynomials
{
    public class Polynomial
    {
        public static int[] AddPolynomials(int[] p1, int[] p2)
        {
            int[] shorter;
            int[] longer;
            if (p1.Length>p2.Length)
            {
                longer = p1;
                shorter = p2;
            }
            else
            {
                longer = p2;
                shorter = p1;
            }
            int[] result = new int[longer.Length];

            int d = longer.Length - shorter.Length;
            if (d!=0)
            {
                for (int i = 0; i < d; i++)
                {
                    result[i] = longer[i];
                }
            }
            for (int i = 0; i < shorter.Length; i++)
            {
                result[i + d] = longer[i + d] + shorter[i];
            }

            return result;
        }

        public static int[] SubtractPolynomials(int[] p1, int[] p2)
        {
            int[] shorter;
            int[] longer;
            if (p1.Length > p2.Length)
            {
                longer = p1;
                shorter = p2;
            }
            else
            {
                longer = p2;
                shorter = p1;
            }
            int[] result = new int[longer.Length];

            int d = longer.Length - shorter.Length;
            if (d != 0)
            {
                for (int i = 0; i < d; i++)
                {
                    result[i] = longer[i];
                }
            }
            for (int i = 0; i < shorter.Length; i++)
            {
                result[i + d] = longer[i + d] - shorter[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
