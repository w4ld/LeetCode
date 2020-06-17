using System;   
using System.Text;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            LeetCodeLibrary.SmallerNumbersThanCurrentTest();
            //LeetCodeLibrary.FindNumbersTest();
            //  HammingDistanceTesting();
            //SortStringTest();
            #region String String Multiply Testing

            #endregion
            //   ReversePairsTest(); //revisit for efficiency

        }
        #region ReversePairs Testing
        public static void ReversePairsTest() {
            #region ReversePairs Testing
            Console.WriteLine(2 == ReversePairs(new int[] { 1, 3, 2, 3, 1 }));
            Console.WriteLine(ReversePairs(new int[] { 1, 3, 2, 3, 1 }));
            //      0 0  0  0
            //        0  0  1
            //           0  0
            //              1
            Console.WriteLine(3 == ReversePairs(new int[] { 2, 4, 3, 5, 1 }));
            Console.WriteLine(ReversePairs(new int[] { 2, 4, 3, 5, 1 }));
            Console.WriteLine(0 == ReversePairs(new int[] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, }));
            Console.WriteLine(ReversePairs(new int[] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, }));
            Console.WriteLine(9 == ReversePairs(new int[] { 2147483647, 2147483647, -2147483647, -2147483647, -2147483647, 2147483647 }));
            Console.WriteLine(ReversePairs(new int[] { 2147483647, 2147483647, -2147483647, -2147483647, -2147483647, 2147483647 }));
            //                  0           1           1           1               0
            //                              1           1           1               0
            //                              0           1           1               0
            //                                          1           1               0
            //                                                      1               0
            //int[] deathcase =           
            //StreamReader streamReader = new StreamReader(@"C:\Users\Derek\source\repos\LeetCode\Csharp\LeetCoding\Resources\BigIntCSV.csv");
            //string[] deathstrings = streamReader.ReadToEnd().Split(',');
            //int[] deathcase = new int[deathstrings.Length];
            //Console.Write("Num of ints:\t");
            //Console.WriteLine(deathstrings.Length);
            //for (int x = 0; x < deathstrings.Length; x++)
            //    deathcase[x] = Convert.ToInt32(deathstrings[x]);
            //Console.WriteLine("Testing deathcase...");
            //Console.WriteLine(ReversePairs(deathcase));
            //Console.WriteLine();
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);

            #endregion
        }
        #endregion
        #region ReversePairs
        /***********************************************
         * Need efficiency on this. right idea, but not within time constraint
         * make BST
         * ********************************************/
        public static int ReversePairsBrute(int[] nums)
        {
            int pairs = 0;
            //Given an array nums, 
            //we call(i, j) an important reverse pair 
            //  if i < j and nums[i] > 2 * nums[j].
            int len = nums.Length;
            for (int i = 0; i < len - 1; i++)
                for (int j = i + 1; j < len; j++)
                {
                    bool notPOF = nums[j] > int.MaxValue / 2;
                    bool notNOF = nums[j] < int.MinValue / 2;
                    bool cond = nums[i] > 2 * nums[j];
                    if (!notNOF && !notPOF && cond)
                        pairs++;
                    else if (notNOF)
                    {
                        if (nums[i] >= int.MinValue)    //handles neg overflow of nums[j]
                            pairs++;
                    }


                }
            return pairs;
        }
        public static int ReversePairs(int[] nums)//BST
        {
            //https://leetcode.com/problems/reverse-pairs/  
            int pairs = 0;
            int len = nums.Length;
            if (len > 0)
            {
                BinaryTreeNode head = null;
                for (int i = 0; i < len; i++)
                {
                    pairs += FindPairs(head, 2 * nums[i] + 1);
                    head = BSTInsert(head, nums[i]);
                }
                return pairs;
            }
            else
                return 0;
        }

        public class BinaryTreeNode
        {
            public int? Value = null;
            public int GECounter = 1;
            public BinaryTreeNode LeftNode = null;
            public BinaryTreeNode RightNode = null;
            public BinaryTreeNode(int val)
            {
                this.Value = val;
            }
            public BinaryTreeNode()
            {
                ;
            }
        }
        static BinaryTreeNode BSTInsert(BinaryTreeNode head, int val)
        {
            if (head == null)
                return new BinaryTreeNode(val);
            else if (val == head.Value)
                head.GECounter++;
            else if (val < head.Value)
                head.LeftNode = BSTInsert(head.LeftNode, val);
            else
            {
                head.GECounter++;
                head.RightNode = BSTInsert(head.RightNode, val);
            }
            return head;
        }
        public static int FindPairs(BinaryTreeNode binaryTree, int target)
        {
            if (binaryTree == null)
                return 0;
            else if (target == binaryTree.Value)
                // Console.WriteLine($"Node: {binaryTree.Value}\tTarget: {target}");
                return binaryTree.GECounter;
            else if (target < binaryTree.Value)
                return binaryTree.GECounter + FindPairs(binaryTree.LeftNode, target);
            else
                return FindPairs(binaryTree.RightNode, target);
        }
        //public static void BinaryTreeInsert(BinaryTreeNode binaryTree, int value)
        //{
        //    if (binaryTree == null)
        //    {
        //        binaryTree = new BinaryTreeNode(value);
        //        binaryTree.Value = value;
        //        Console.WriteLine($"Inserting: {binaryTree.Value}");
        //    }
        //    else
        //    {
        //        if (value < binaryTree.Value)
        //        {
        //            Console.Write($" (L of {binaryTree.Value}) ");
        //            BinaryTreeInsert(binaryTree.LeftNode, value);
        //        }
        //        else
        //        {
        //            binaryTree.GECounter++;
        //            Console.Write($" (R of {binaryTree.Value}) ");
        //            BinaryTreeInsert(binaryTree.RightNode, value);
        //        }
        //    }
        //}
        //Node* insert(Node* head, int val)


        #endregion
        #region SortString Testing
        public static void SortStringTest()
        {
            Console.WriteLine(("abccbaabccba" == SortString("aaaabbbbcccc")) ? "Pass" : "Fail");
            Console.WriteLine(SortString("aaaabbbbcccc"));
            //Explanation: After steps 1, 2 and 3 of the first iteration, result = "abc"
            //After steps 4, 5 and 6 of the first iteration, result = "abccba"
            //First iteration is done.Now s = "aabbcc" and we go back to step 1
            //After steps 1, 2 and 3 of the second iteration, result = "abccbaabc"
            //After steps 4, 5 and 6 of the second iteration, result = "abccbaabccba"
            //Example 2:

            Console.WriteLine(("art" == SortString("rat")) ? "Pass" : "Fail");
            Console.WriteLine(SortString("rat"));
            //Explanation: The word "rat" becomes "art" after re-ordering it with the mentioned algorithm.
            Console.WriteLine(("cdelotee" == SortString("leetcode")) ? "Pass" : "Fail");
            Console.WriteLine(SortString("leetcode"));
            Console.WriteLine(("gggggggg" == SortString("gggggggg")) ? "Pass" : "Fail");
            Console.WriteLine(SortString("gggggggg"));
            Console.WriteLine(("spo" == SortString("ops")) ? "Pass" : "Fail");
            Console.WriteLine(SortString("ops"));
        }
        #endregion
        #region SortString
        public static string SortString(string s)
        {
            //https://leetcode.com/problems/increasing-decreasing-string/
            StringBuilder result = new StringBuilder();
            int len = s.Length;
            char[] arr = new char[len];
            for (int i = 0; i < len; i++)
                arr[i] = s[i];
            QuickSort(arr, 0, len - 1);

            result.Append(arr[0]);
            //            Pick the smallest character from s and append it to the result.
            char lastchar = arr[0];
            int nocharsleft = 1;
            int index = 1;
            int mindex = 1;
            int maxdex = len - 1;
            bool isIncreasing = true;
            bool firstchar = false;
            while (nocharsleft < len)
            {
                if (firstchar)
                {
                    result.Append(arr[index]);
                    if (isIncreasing)
                        index++;
                    else
                        index--;
                    lastchar = arr[index];
                    arr[index] = ' ';
                    firstchar = false;
                    nocharsleft++;
                }
                if (isIncreasing) {
                    if (arr[index] == lastchar)
                    {
                        isIncreasing = false;
                        firstchar = true;
                        mindex = index;
                        index = maxdex;
                    }
                    else if (arr[index] > lastchar)// && arr[index]!=' ')
                    {
                        result.Append(arr[index]);
                        //  arr[index] = ' ';
                        lastchar = arr[index++];
                        nocharsleft++;
                    }
                }
                else//running R to L
                {
                    if (arr[index] == lastchar)
                    {
                        isIncreasing = true;
                        firstchar = true;
                        maxdex = index;
                        index = mindex;
                    }
                    else if (arr[index] < lastchar)// && arr[index] != ' ')
                    {
                        result.Append(arr[index]);
                        //arr[index] = ' ';
                        lastchar = arr[index--];
                        nocharsleft++;
                    }
                }
                //Pick the smallest character from s which is greater than the last appended character to the result and append it.
                //Repeat step 2 until you cannot pick more characters.
                //Pick the largest character from s and append it to the result.
                //Pick the largest character from s which is smaller than the last appended character to the result and append it.
                //Repeat step 5 until you cannot pick more characters.
                //Repeat the steps from 1 to 6 until you pick all characters from s.
            }
            return result.ToString();
        }
        public static int FindLowest(char[] arr)
        {
            int lowest = 0;
            char low_c = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < low_c && arr[i] != ' ')
                {
                    lowest = i;
                    low_c = arr[i];
                }
            return lowest;
        }
        static void QuickSort(char[] s, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(s, low, high);
                QuickSort(s, low, p - 1);
                QuickSort(s, p + 1, high);
            }

        }

        public static void Swap(char[] s, int i, int j)
        {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
        }
        public static int Partition(char[] s, int low, int high)
        {
            //algorithm partition(A, lo, hi) is
            //    pivot := A[hi]
            int pivot = s[high];
            //    i := lo
            int i = low;
            //    for j := lo to hi do
            for (int j = low; j < high; j++)
            {
                //        if A[j] < pivot then
                if (s[j] < pivot)
                {
                    //            swap A[i] with A[j]
                    Swap(s, i, j);
                    //  i := i + 1
                    i = i + 1;
                }
            }
            //    swap A[i] with A[hi]
            Swap(s, i, high);
            //    return i
            return i;
        }
        #endregion
        #region String String Multiply
        //public string Multiply(string num1, string num2)
        //{
        //    StringBuilder product = new StringBuilder();
        //    int len1 = num1.Length;
        //    int len2 = num2.Length;
        //    int lenMax = (len1 > len2) ? len1 : len2;
        //    for(int i = lenMax - 1; i > -1; i--)
        //    {

        //    }
        //}
        #endregion
        #region HammingDistance Testing
        //public static void HammingDistanceTesting()
        //{
        //    //Input: x = 1, y = 4
        //    //Output: 2
        //    //Explanation:
        //    //1   (0 0 0 1)
        //    //4   (0 1 0 0)
        //    Console.WriteLine((2 == HammingDistance(1, 4)) ? "Pass" : "Fail");
        //    Console.WriteLine(HammingDistance(1, 4));
        //}

        #endregion
        #region HammingDistance
        //public static int HammingDistance(int x, int y)
        //{
        //    //https://leetcode.com/problems/hamming-distance/
        //    string binaryx = Convert.ToString(x, 2);
        //    string binaryy = Convert.ToString(y, 2);
        //    Console.WriteLine(binaryx);
        //    Console.WriteLine(binaryy);
        //    int xlen = binaryx.Length;
        //    int ylen = binaryy.Length;
        //    if (xlen > ylen) { 
        //    //pad y to x
        //    }
        //    else if (ylen < xlen) {
        //    //pad x to y
        //    }

        //    int xoff = (len - xlen);
        //    int yoff = (len - ylen);
        //    for(int i=len-1; i>-1; i--)
        //    {
        //        if((i - xoff) > -1 && (i - yoff) > -1)//both are good

        //        bi = (i - boff) > -1 ? b[i - boff] - 48 : 0;

        //        //if(bi)
        //    }
        //    return 0;
        //}
        #endregion
        
    }
}
