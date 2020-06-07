using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region PrintObjects
        public static void PrintIntArray(int[] arr)
        {
            Console.Write("[ ");
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("]");
        }
        #endregion
    }
}
