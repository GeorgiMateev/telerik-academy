using System;
using System.Collections.Generic;

namespace _10.Factorials
{
    public static class Factorial
    {
        /// <summary>
        /// Multiplying two numbers,represented in arrays.
        /// </summary>
        /// <param name="number1">The zero index are tens , first index are hundrets etc.</param>
        /// <param name="number2">The zero index are tens , first index are hundrets etc.</param>
        /// <returns>Return the multiplication. The zero index are tens , first index are hundrets etc.</returns>
        static sbyte[] MultiplyNumbersAsArrays(sbyte[] number1, sbyte[] number2)
        {
            List<List<sbyte>> multiplications = new List<List<sbyte>>();
            for (int i = 0; i < number2.Length; i++)
            {
                List<sbyte> multiply = new List<sbyte>();
                for (int j = 0; j < number1.Length; j++)
                {
                    multiply.Add((sbyte)(number1[j] * number2[i]));
                }
                Factorial.DistributeDecimals(multiply);
                multiplications.Add(multiply);
            }

            List<sbyte> result = Factorial.AddTwoMultiplications(multiplications[0],multiplications[1],1);
            for (int i = 2; i < multiplications.Count; i++)
            {
                result=Factorial.AddTwoMultiplications(result,multiplications[i],2);
            }
      
            Factorial.DistributeDecimals(result);
            return result.ToArray();
        }

        static List<sbyte> DistributeDecimals(List<sbyte> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= 10)
                {
                    sbyte n = list[i];
                    list[i] = (sbyte)(n % 10);
                    if (i + 1 >= list.Count)
                    {
                        list.Add((sbyte)(n / 10));
                    }
                    else
                    {
                        list[i + 1] += (sbyte)(n / 10);
                    }
                }
            }
            return list;
        }
        static List<sbyte> AddTwoMultiplications(List<sbyte> upper, List<sbyte> down,int d)
        {
            List<sbyte> result = new List<sbyte>();
            for (int i = 0; i < d; i++)
            {
                result.Add(upper[i]);
            }
            
            for (int i = 0; i < down.Count || i + d < upper.Count; i++)
            {
                if (i<down.Count && i+d< upper.Count)
                {
                    result.Add((sbyte)(upper[i + d] + down[i]));
                }
                else
                {
                    if (i>=down.Count)
                    {
                        result.Add(upper[i + d]);
                    }
                    else
                    {
                        result.Add(down[i]);
                    }
                }
            }
            Factorial.DistributeDecimals(result);
            return result;
        }

        /// <summary>
        /// Decrases number with 1.
        /// </summary>
        /// <param name="number">Number in array.</param>
        static void DecreaseNumberAsArray(sbyte[] number)
        {
            int i=-1;
            for (i = 0; number[i]==0; i++)
			{
                number[i] = 9;                
			}
            number[i + 1]--;
        }

        public static void FactorialInArray(int n)
        {
            List<sbyte> number = new List<sbyte>();
            while (n!=0)
	        {
	            number.Add((sbyte)(n%10));
                n/=10;
	        }

        }

        static void Main()
        {
           
        }
    }
}
