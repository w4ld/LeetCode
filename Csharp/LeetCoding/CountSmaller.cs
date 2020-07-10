using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region  CountSmaller Testing
        public static void CountSmallerTest()
        {
            int[] test1 = { 1, 2, 3, 4 };
            int[] test2 = { 1, 2, 3, 9 };
            int[] test3 = { 9, 9, 9, 9 };
            int[] test4 = { 5, 2, 6, 1 };
            int[] test5 = { 26, 78, 27, 100, 33, 67, 90, 23, 66, 5, 38, 7, 35, 23, 52, 22, 83, 51, 98, 69, 81, 32, 78, 28, 94, 13, 2, 97, 3, 76, 99, 51, 9, 21, 84, 66, 65, 36, 100, 41 };
            int[] output5 = { 10, 27, 10, 35, 12, 22, 28, 8, 19, 2, 12, 2, 9, 6, 12, 5, 17, 9, 19, 12, 14, 6, 12, 5, 12, 3, 0, 10, 0, 7, 8, 4, 0, 0, 4, 3, 2, 0, 1, 0 };
            PrintIntArray(test1);
            PrintIntArray((int[])CountSmaller(test1));
            PrintIntArray(test2);
            PrintIntArray((int[])CountSmaller(test2));
            PrintIntArray(test3);
            PrintIntArray((int[])CountSmaller(test3));
            PrintIntArray(test4);
            PrintIntArray((int[])CountSmaller(test4));
        }
        #endregion
        #region  CountSmaller inefficient BST...
        
        public IList<int> CountSmaller2(int[] nums)
        {
            int numsSize = nums.Length;
            int[] retArr = new int[numsSize];
            BinaryTreeNode searchTree = null;
            for (int n = 0; n < numsSize; n++)
            {
                searchTree = BSTInsert(searchTree, nums[n], n);
            }
            for (int n = 0; n < numsSize; n++)
                retArr[n] = FindSmaller(searchTree, nums[n], n);

            return retArr;
        }
        public class BinaryTreeNode
        {
            public int? Value = null;
            public int? Index = null;
            public int LCounter = 0;
            public BinaryTreeNode LeftNode = null;
            public BinaryTreeNode RightNode = null;
            public BinaryTreeNode(int val, int index)
            {
                this.Value = val;
                this.Index = index;
            }
            public BinaryTreeNode()
            {
                ;
            }
        }
        static BinaryTreeNode BSTInsert(BinaryTreeNode head, int val, int index)
        {
            if (head == null)
                return new BinaryTreeNode(val, index);
            else if (val < head.Value)
            {
                head.LeftNode = BSTInsert(head.LeftNode, val, index);
                head.LCounter++;
                //increment all nodes to right of 
                if (head.RightNode != null)
                    IncrementHelper(head.RightNode);
            }
            else
            {
                head.RightNode = BSTInsert(head.RightNode, val, index);
            }
            return head;
        }
        public static int FindSmaller(BinaryTreeNode binaryTree, int target, int index)
        {
            if (binaryTree == null)
                return 0;
            else if (target > binaryTree.Value)
                return FindSmaller(binaryTree.RightNode, target, index);
            else if (target == binaryTree.Value)
                if (index == binaryTree.Index)
                    return binaryTree.LCounter;
                else
                    return FindSmaller(binaryTree.RightNode, target, index);
            else
                return FindSmaller(binaryTree.LeftNode, target, index);
        }
        public static void IncrementHelper(BinaryTreeNode binaryTree)
        {
            binaryTree.LCounter++;
            if (binaryTree.RightNode != null)
                IncrementHelper(binaryTree.RightNode);
            if (binaryTree.LeftNode != null)
                IncrementHelper(binaryTree.LeftNode);

        }
        #endregion
        #region modified list
        public static IList<int> CountSmaller(int[] nums)
        {
            int i, j, c, numsLen = nums.Length;
            int[] retarr = new int[numsLen];
            for (i = numsLen-1; i>-1 ; i--)
            {
                c = 0;
                for (j = i; j < numsLen; j++)
                    if (nums[j] < nums[i])
                        ++c;
                retarr[i] = c;
            }
            return retarr;
        }

        #endregion
        #region CountSmaller Brute
  
        public static IList<int> CountSmaller3(int[] nums)
        {
            int i, j, c, numsLen = nums.Length;
            int[] retarr = new int[numsLen];
            for (i = 0; i < numsLen; i++)
            {
                c = 0;
                for (j = i + 1; j < numsLen; j++)
                    if (nums[j] < nums[i])
                        ++c;
                retarr[i] = c;
            }
            return retarr;
        }


        public static IList<int> CountSmaller4(int[] nums)
        {
            int i, j, c, numsLen = nums.Length;
            int[] retarr = new int[numsLen];
            for (i = numsLen - 1; i > -1; i--)
            {
                c = 0;
                for (j = i; j < numsLen; j++)
                    if (nums[j] < nums[i])
                        ++c;
                retarr[i] = c;
            }
            return retarr;
        }
        #endregion

    }
}
