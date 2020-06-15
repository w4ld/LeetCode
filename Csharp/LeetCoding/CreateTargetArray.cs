using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region CreateTargetArray
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> organizer = new List<int>();
            for (int i = 0; i < index.Length; i++)
                organizer.Insert(index[i], nums[i]);
            return organizer.ToArray();
        }
        #endregion
        #region CreateTargetArrayTesting
        public static void CreateTargetArrayTest()
        {
            int[] nums = { 0, 1, 2, 3, 4 }, index = { 0, 1, 2, 2, 1 },
                    nums2 = {1, 2, 3, 4, 0}, index2 = {0, 1, 2, 3, 0},
                    nums3 = {1}, index3 = {0},
                    output1={0,4,1,3,2}, output2={0,1,2,3,4},
                    output3={1};
            int[] retarr1 = CreateTargetArray(nums, index);
            PrintIntArray(output1);
            PrintIntArray(retarr1);
          
            int[] retarr2 = CreateTargetArray(nums2, index2);
            PrintIntArray(output2);
            PrintIntArray(retarr2);
            int[] retarr3 = CreateTargetArray(nums3, index3);
            PrintIntArray(output3);
            PrintIntArray(retarr3);
        }
        #endregion
    }
}
