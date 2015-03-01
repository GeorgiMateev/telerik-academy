using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.StringBuilder_Substring
{
    public static class Substring
    {
        /// <summary>
        /// Return substring starting from specified index and given length.
        /// </summary>
        /// <param name="str">Current StringBuilder.</param>
        /// <param name="index">Starting index.</param>
        /// <param name="length">The length of the substring.</param>
        /// <returns>StringBuilder with the substring.</returns>
        public static StringBuilder GetSubstring(this StringBuilder str, int index, int length)
        {
            StringBuilder substring = new StringBuilder();
            int endIndex = index + length - 1;
            for (int i = index; i <= endIndex; i++)
            {
                substring.Append(str[i]);
            }
            return substring;
        }
    }
}
