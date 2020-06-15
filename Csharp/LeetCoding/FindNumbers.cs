using System;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        public static int FindNumbers(int[] nums)
        {   
            int ret = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int x = 1;
                while ((nums[i] /= 10) > 0)
                    x++;
                if (x % 2 == 0)
                    ret++;
            }
            return ret;
        }

        public static void FindNumbersTest()
        {
            int[] nums = { 555, 901, 482, 1771 };
            int[] nums2 = {12, 345, 2, 6, 7896};
            Console.WriteLine((FindNumbers(nums) == 1) ? "Pass" : "Fail");
            Console.WriteLine((FindNumbers(nums2) == 2) ? "Pass" : "Fail");
        }
    }
}