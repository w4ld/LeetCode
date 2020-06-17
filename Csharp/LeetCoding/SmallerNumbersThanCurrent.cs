﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region  SmallerNumbersThanCurrent Testing
        public static void SmallerNumbersThanCurrentTest()
        {
            int[] test1 = { 1, 2, 3, 4 };
            int[] test2 = { 1, 2, 3, 9 };
            int[] test3 = { 9, 9, 9, 9 };
            PrintIntArray(test1);
            PrintIntArray(SmallerNumbersThanCurrent(test1));
            PrintIntArray(test2);
            PrintIntArray(SmallerNumbersThanCurrent(test2));
            PrintIntArray(test3);
            PrintIntArray(SmallerNumbersThanCurrent(test3));
        }
        #endregion
        #region  SmallerNumbersThanCurrent
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int i, j, c;
            int numsSize = nums.Length;
            int[] retArr = new int[numsSize];
            for (i = 0; i < numsSize; i++)
            {
                c = 0;
                for (j = 0; j < numsSize; j++)
                {
                    if (nums[j] < nums[i] && j != i)
                    {
                        ++c;
                    }
                }
                retArr[i] = c;
            }
            return retArr;
        }
        #endregion

    }
}
