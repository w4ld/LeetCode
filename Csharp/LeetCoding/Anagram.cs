using System;
using System.Diagnostics;
using System.Threading;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        public static bool IsAnagram(string s, string t)
        {
            if ((s.Length != t.Length) || s.Length==0)
                return false;
            char[] sa = s.ToCharArray();
            char[] ta = t.ToCharArray();

            Array.Sort(sa);
            Array.Sort(ta);

            for (int i = 0; i < sa.Length; i++)
                if (sa[i] != ta[i])
                    return false;

            return true;
        }

        public static bool IsAnagram2(string s, string t)
        {
            if (s.Length != t.Length || s.Length == 0)
                return false;
           foreach(char c in s)
            {
                int index = t.IndexOf(c);
                if (index != -1)
                    t=t.Remove(index, 1);
                else
                    return false;
            }
            if (String.IsNullOrEmpty(t))
                return true;
            return false;
        }

        #region IsAnagram Testing
        public static void IsAnagramTest()
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram") == true);
            Console.WriteLine(IsAnagram("anagram", "nagarat") == false);
            Console.WriteLine(IsAnagram("", "") == false);
            Console.WriteLine(IsAnagram2("anagram", "nagaram") == true);
            Console.WriteLine(IsAnagram2("anagram", "nagarat") == false);
            Console.WriteLine(IsAnagram2("", "") == false);
            //big test
            string a = "anagram";
            string b = "nagaram";
            for(int i=0; i<3; i++)
            {
                a += a;
                b += b;
            }
            string c = a, d = b;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(  IsAnagram(a, b));
            sw.Stop();
            Console.WriteLine("SortedElapsed={0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            Console.WriteLine(  IsAnagram2(c, d));
            sw.Stop();
            Console.WriteLine("strReplaceElapsed={0}", sw.Elapsed);

        }
            #endregion
    }
}