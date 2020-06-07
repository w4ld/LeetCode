using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region AddToArrayForm Testing
        public static void AddToArrayFormTest()
        {
            int[] a = { 2, 1, 3 };
            foreach (int i in AddToArrayForm(a, 0))
                Console.WriteLine(i);
        }
        #endregion
        #region AddToArrayForm
        public static IList<int> AddToArrayForm(int[] A, int K)
        {
            List<int> retList = new List<int>();
            int carry = 0, sum, k2;
            for (int i = A.Length - 1; i > -1; i--)
            {
                k2 = (K > 0) ? K % 10 : 0;
                sum = A[i] + k2 + carry;
                carry = sum / 10;
                retList.Insert(0, sum % 10);
                K = (K > 9) ? K / 10 : 0;
            }
            while (K > 0)
            {
                k2 = (K > 0) ? K % 10 : 0;
                sum = k2 + carry;
                retList.Insert(0, sum);
                K = (K > 9) ? K / 10 : 0;
            }
            if (carry > 0)
                retList.Insert(0, carry);
            return retList;
        }
        #endregion
    }
}
