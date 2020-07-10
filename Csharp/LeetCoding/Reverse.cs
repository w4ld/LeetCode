using System;
using System.Diagnostics;
using System.Threading;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        public static void ReverseString(char[] s)
        {
            char t;
            int j = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++, j--)
            {
                t = s[i];
                s[i] = s[j];
                s[j] = t;
            }
        }

        #region ReverseString Testing
        public static void ReverseStringTest()
        {
            char[] hello = { 'h', 'e', 'l', 'l', 'o' };
            char[] hellor = { 'o', 'l', 'l', 'e', 'h' };
            char[] a = { 'a' };            
            char[] ab = { 'a', 'b' };            
            char[] ba = { 'b', 'a' };            
            ReverseString(hello);
            Console.WriteLine(hello == hellor);
            ReverseString(a);
            ReverseString(ab);
            Console.WriteLine( ab == ba);
            
        }
            #endregion
    }
}