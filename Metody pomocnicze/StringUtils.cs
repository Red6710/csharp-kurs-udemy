using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Metody_pomocnicze
{
    public class StringUtils
    {
        public string ReverseString(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length-1; i >= 0; i--)
            {
                char currentChar = input[i];

                sb.Append(currentChar);
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        public int CountOccurrences(string input, string fragment)
        {
            int fragmentLength = fragment.Length;
            int count = 0;
            for (int i = 0; i <= input.Length - fragment.Length; i++)
            {
                count += input.Substring(i,fragmentLength).Contains(fragment) ? 1 : 0; ; 
                
            }
            return count;
        }

        public string RemoveWhitespace(string input)
        {
           return Regex.Replace(input, @"\s+", "");

        }
    }
}
