using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region PlusOne Testing
        public static void PlusOneTesting()
        {
            int[] test1 = { 1, 2, 3, 4 };
            int[] test2 = { 1, 2, 3, 9 };
            int[] test3 = { 9, 9, 9, 9 };
            PrintIntArray(test1);
            PrintIntArray(PlusOne(test1));
            PrintIntArray(test2);
            PrintIntArray(PlusOne(test2));
            PrintIntArray(test3);
            PrintIntArray(PlusOne(test3));
        }
        #endregion
        #region PlusOne
        public static int[] PlusOne(int[] digits)
        {
            int len = digits.Length - 1;
            int carry = 0;
            for (int i = len; i > -1; i--)
            {
                if (i == len)
                {
                    if (++digits[i] < 10) //
                        return digits;
                    else
                    {
                        carry = 1;
                        digits[i] = digits[i] % 10;
                    }
                }
                else if (carry != 0)//handle carry  
                {
                    if (++digits[i] < 10) //
                        return digits;
                    else
                    {
                        carry = 1;
                        digits[i] = digits[i] % 10;
                    }
                }
                else
                    return digits;

            }
            if (carry > 0)
            {
                int[] edgeCarryAll = new int[len + 2];
                edgeCarryAll[0] = carry;
                digits.CopyTo(edgeCarryAll, 1);
                return edgeCarryAll;
            }
            return digits;
        }
        #endregion

    }
}
