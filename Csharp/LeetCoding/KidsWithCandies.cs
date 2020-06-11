using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region KidsWithCandies Testing
        public static void KidsWithCandiesTest()
        {
        //      Input: candies = [2, 3, 5, 1, 3], extraCandies = 3
        //      Output:[true,true,true,false,true] 
            int[] test1cdy = { 2, 3, 5, 1, 3 };
            var test1 = KidsWithCandies(test1cdy, 3);
            foreach (var t in test1)
                Console.WriteLine(t);
        }
        #endregion
        #region KidsWithCandies
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            //<bool> retList = new List<bool>();
            int len = candies.Length;
            bool[] retArr = new bool[len];
            int greatest = candies[0];
            for (int i = 1; i < len; i++)
                if (candies[i] > greatest)
                    greatest = candies[i];
            for (int i = 0; i < len; i++)
                retArr[i] = ((candies[i] + extraCandies >= greatest) ? true : false);
            return retArr;
        }
        #endregion
    }
}
