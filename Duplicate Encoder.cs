using System;
using System.Collections.Generic;

namespace Duplicate_Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
  
        }
    }

    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            Dictionary<char, Int16> char_dict = new Dictionary<char, Int16>();
            word = word.ToLower();
            foreach (char c in word)
            {
                if (char_dict.ContainsKey(c))
                {
                    char_dict[c] += 1;
                }
                else
                {
                    char_dict[c] = 1;
                }
            }
            var res = "";
            foreach (char letter in word)
            {
                if (char_dict[letter] > 1)
                {
                    res += ")";
                }
                else
                {
                    res += "(";
                }
            }
            return res;
        }
    }


}
