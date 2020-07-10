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
        public static void PrintIntList(List<int> list)
        {
            Console.Write("[ ");
            foreach (int i in list)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("]");
        }
        #endregion
        #region Swap
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
     
        #endregion
    }
}
