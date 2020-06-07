using System;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }
        #region TwoSum Testing
        public static void TwoSumTest()
        {
            int[] testArr = { 1, 2, 3, 5, 6, 7, 8, 9, 11 };
            int target = 9;
            int[] retIndices = TwoSum(testArr, target);
            Console.WriteLine($"Indexes for [{retIndices[0]}, {retIndices[1]}] for target {target}");
            target = 19;
            retIndices = TwoSum(testArr, target);
            Console.WriteLine($"Indexes for [{retIndices[0]}, {retIndices[1]}] for target {target}");
        }
            #endregion
    }
}