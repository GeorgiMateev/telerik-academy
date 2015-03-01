using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MiscUtil;

namespace _2.IEnumerable_Extensions
{
    static class IEnumerableExtensions
    {
        
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            T sum = Operator<T>.Zero;
            foreach (var item in collection)
            {
                if (item != null)
                {
                    sum = Operator.Add(sum, item);
                }
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            T product = Operator.Convert<int, T>(1);
            foreach (var item in collection)
            {
                if (item != null)
                {
                    product = Operator.Multiply(product, item);
                }
            }
            return product;
        }

        /// <summary>
        /// Finds average of the collection.
        /// </summary>       
        public static T Average<T>(this IEnumerable<T> collection)
        {
            T sum = Operator<T>.Zero;
            int count = 0;
            foreach (var item in collection)
            {
                if (item != null)
                {
                    sum = Operator.Add(sum, item);
                    count++;
                }
            }

            if (count==0)
            {
                sum = default(T);
                if (sum != null)
                {
                    throw new InvalidOperationException();
                }
                return sum;
            }
            else
            {
                return Operator.DivideInt32(sum, count);
            }
        }

        public static T Minimum<T>(this IEnumerable<T> collection)
        {
            return collection.Min();
        }

        public static T Maximum<T>(this IEnumerable<T> collection)
        {
            return collection.Max();
        }

        
    }
}
