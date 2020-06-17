using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {

        #region AddBinary
        public static string AddBinary(string a, string b)
        {
            StringBuilder retString = new StringBuilder();
            int alen = a.Length;
            int blen = b.Length;
            int length = (alen > blen) ? alen : blen;
            int aoff, boff, ai, bi, sum, carry = 0;
            aoff = (length - alen);
            boff = (length - blen);

            for (int i = length - 1; i > -1; i--)
            {
                ai = (i - aoff) > -1 ? a[i - aoff] - 48 : 0;
                bi = (i - boff) > -1 ? b[i - boff] - 48 : 0;
                sum = ai + bi + carry;
                //Console.WriteLine("sum:{0}", sum);
                retString.Insert(0, sum % 2);
                carry = sum / 2;
                //Console.WriteLine(retString.ToString());
            }
            if (carry > 0)
                retString.Insert(0, 1);
            return retString.ToString();
        }
        #endregion
    }
}
