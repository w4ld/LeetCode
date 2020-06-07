using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region AddStrings  
        public static string AddStrings(string num1, string num2)
        {
            StringBuilder retString = new StringBuilder();
            int len1 = num1.Length, len2 = num2.Length;
            int length = (len1 > len2) ? len1 : len2;
            int carry = 0;
            int n1, n2, sum, offset1, offset2;
            for (int i = length - 1; i > -1; i--)
            {
                offset1 = i - (length - len1);
                offset2 = i - (length - len2);
                n1 = (offset1 > -1) ? num1[offset1] - 48 : 0;
                n2 = (offset2 > -1) ? num2[offset2] - 48 : 0;
                sum = (n1 + n2 + carry);
                carry = sum / 10;
                retString.Insert(0, sum % 10);
            }
            if (carry > 0)
                retString.Insert(0, carry);
            return retString.ToString();
        }
        #endregion



        public static void AddStringsTest()
        {
            #region AddStrings Testing
            Console.WriteLine(AddStrings("111", "222"));
            Console.WriteLine(AddStrings("111100000000", "222"));
            #endregion
        }
    }
}
