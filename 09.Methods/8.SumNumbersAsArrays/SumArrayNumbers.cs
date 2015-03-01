using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.SumNumbersAsArrays
{
    class SumArrays
    {
        static int[] SumArrayNumbers(int[] n1, int[] n2)
        {
            List<int> result = new List<int>();
            int[] longer;
            int[] shorter;
            if (n1.Length>n2.Length)
            {
                longer = n1;
                shorter = n2;
            }
            else
            {
                longer = n2;
                shorter= n1;
            }
            for (int i = 0; i < longer.Length; i++)
            {
                if (i >= shorter.Length)
                {
                    result.Add(longer[i]);
                }
                else
                {
                    int digitSum = n1[i] + n2[i];                    
                    result.Add(digitSum);                    
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i]>=10)
                {
                    int n = result[i];
                    result[i] = n % 10;
                    if (i+1>=result.Count)
                    {
                        result.Add(n / 10);
                    }
                    else
                    {
                        result[i + 1] += n / 10;
                    }
                }
            }
            return result.ToArray();
        }
        static void Main(string[] args)
        {
            int[] n1 = new int[] { 3,5,3,9,9,};
            int[] n2 = new int[] { 0,6,7,9};

            int[] result = SumArrayNumbers(n2, n1);

            foreach (var item in result)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
