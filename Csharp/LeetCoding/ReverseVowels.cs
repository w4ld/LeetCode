using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        public static string ReverseVowels(string s)
        {
            List<int> vowels = new List<int>();
            char[] sc = s.ToCharArray();
            for (int i = 0; i < sc.Length; i++)
            {
                if (IsVowel(sc[i]))
                    vowels.Add(i);
            }
            char t;
            int j = vowels.Count - 1;
            for (int i = 0; i < vowels.Count / 2; i++)
            {
                t = sc[vowels[j]];
                sc[vowels[j]] = sc[vowels[i]];
                sc[vowels[i]] = t;
                j--;
            }
            return String.Join("", sc);
        }
        public static bool IsVowel(char c)
        {
            if (c == 'e' || c == 'a' || c == 'i' || c == 'o' || c == 'u' ||
               c == 'E' || c == 'A' || c == 'I' || c == 'O' || c == 'U')
                return true;
            return false;

        }

        #region ReverseString Testing
        public static void ReverseVowelsTest()
        {
            Console.WriteLine(ReverseVowels("hello") == "holle");
            Console.WriteLine(ReverseVowels("hello"));
            Console.WriteLine(ReverseVowels("hhh"));
            Console.WriteLine(ReverseVowels("hheh"));
            Console.WriteLine(ReverseVowels("ahheh"));
            Console.WriteLine(ReverseVowels("ae"));
            Console.WriteLine(ReverseVowels("a"));
            Console.WriteLine(ReverseVowels(""));
            Console.WriteLine(ReverseVowels("leetcode"));
            
        }
            #endregion
    }
}