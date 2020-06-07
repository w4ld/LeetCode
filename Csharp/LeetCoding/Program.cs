using System;   
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Transactions;

namespace LeetCode
{
    public class Program   
    {
        static void Main(string[] args)
        {
           
            #region AddStrings Testing
            //Console.WriteLine(AddStrings("111", "222"));
            //Console.WriteLine(AddStrings("111100000000", "222"));
            #endregion
            #region AddToArrayForm Testing
            //int[] a = { 2, 1, 3 };
            //foreach(int i in AddToArrayForm(a, 0))
            //    Console.WriteLine(i);
            #endregion
            #region AddBinary Testing
            //string b1 = "11010101";
            //string b2 = "00010111";
            //string b3 = "111";
            //Console.WriteLine(b1);
            //Console.WriteLine(b2);
            //Console.WriteLine(AddBinary(b1, b2));
            //Console.WriteLine(AddBinary(b3, b2));
            //Console.WriteLine(b3);
            #endregion
            #region PlusOne Testing
            //int[] test1 = { 1, 2, 3, 4 };
            //int[] test2 = { 1, 2, 3, 9 };
            //int[] test3 = { 9, 9, 9, 9 };
            //PrintIntArray(test1);
            //PrintIntArray(PlusOne(test1));
            //PrintIntArray(test2);
            //PrintIntArray(PlusOne(test2));
            //PrintIntArray(test3);
            //PrintIntArray(PlusOne(test3));            
            #endregion
            #region String String Multiply Testing

            #endregion
            #region KidsWithCandies Testing
            //       Input: candies = [2, 3, 5, 1, 3], extraCandies = 3
            //       Output:[true,true,true,false,true] 
            //int[] test1cdy = { 2, 3, 5, 1, 3 };
            //var test1 = KidsWithCandies(test1cdy, 3);
            //foreach( var t in test1)
            //    Console.WriteLine(t);
            #endregion
            #region DefangIPaddr Testing

            //Console.WriteLine("1[.]1[.]1[.]1" == DefangIPaddr("1.1.1.1"));
            //Console.WriteLine("255[.]100[.]50[.]0" == DefangIPaddr("255.100.50.0"));
            //Console.WriteLine("1[.]1[.]1[.]1" == DefangIPaddr2("1.1.1.1"));
            //Console.WriteLine("255[.]100[.]50[.]0" == DefangIPaddr2("255.100.50.0"));
            //Console.WriteLine("1[.]1[.]1[.]1" == DefangIPaddr("1.1.1.1"));

            #endregion
            #region ReversePairs
            Console.WriteLine(2 == ReversePairs(new int[] { 1, 3, 2, 3, 1 }));
            Console.WriteLine(3 == ReversePairs(new int[] { 2, 4, 3, 5, 1 }));
            #endregion
            //LeetCodeLibrary.TwoSumTest();
            //LeetCodeLibrary.AddTwoNumbersTest();
        }
        #region
        public static int ReversePairs(int[] nums)
        {
            int pairs = 0;
            //Given an array nums, 
            //we call(i, j) an important reverse pair 
            //  if i < j and nums[i] > 2 * nums[j].
            
            return pairs;
        }
        #endregion
        #region DefangIPaddr
        public static string DefangIPaddr(string address)
        {//no need to do the extra work...
            return address.Replace(".", "[.]");
        }
        public static string DefangIPaddr2(string address)
        {//if you cant replace
            StringBuilder retString = new StringBuilder();
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')               
                    retString.Append("[.]");               
                else
                    retString.Append(address[i]);
            }
            return retString.ToString();
        }
        public static string DefangIPaddr3(string address)
        {//if you cant replace
            char[] nuIp= new char[address.Length + 6];
            int nuIpCtr = 0;
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                {
                    nuIp[nuIpCtr++] = '[';
                    nuIp[nuIpCtr++] = '.';
                    nuIp[nuIpCtr++] = ']';
                }                    
                else
                    nuIp[nuIpCtr++] = address[i];
                    
            }
            return new string(nuIp);
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
                retArr[i]=((candies[i] + extraCandies >= greatest) ? true : false);
            return retArr;
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
        #region PlusOne
        public static int[] PlusOne(int[] digits)
        {
            int len = digits.Length-1;
            int carry = 0;
            for (int i= len; i>-1; i--)
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
        #region AddBinary
        public static string AddBinary(string a, string b)
        {
            StringBuilder retString = new StringBuilder();
            int alen = a.Length;
            int blen = b.Length;
            int length = (alen > blen) ? alen : blen;
            int aoff, boff, ai, bi, sum, carry=0;
            aoff = (length - alen);
            boff = (length - blen);
            
            for(int i = length-1; i > -1; i--)
            {
                ai = (i - aoff) > -1 ? a[i - aoff]-48 : 0;
                bi = (i - boff) > -1 ? b[i - boff]-48 : 0;
                sum = ai + bi + carry;
                //Console.WriteLine("sum:{0}", sum);
                retString.Insert(0, sum % 2);
                carry = sum / 2;
                //Console.WriteLine(retString.ToString());
            }
            if (carry > 0)
                retString.Insert(0, 1);
            return retString.ToString();
        }
        #endregion
        #region AddToArrayForm
        public static IList<int> AddToArrayForm(int[] A, int K)
        {
            List<int> retList = new List<int>();
            int carry = 0, sum, k2;
            for (int i = A.Length - 1; i > -1; i--)
            {
                k2 = (K > 0) ? K % 10 : 0;
                sum = A[i] + k2 + carry;
                carry = sum / 10;
                retList.Insert(0, sum % 10);
                K = (K > 9) ? K / 10 : 0;
            }
            while (K > 0)
            {
                k2 = (K > 0) ? K % 10 : 0;
                sum = k2 + carry;
                retList.Insert(0, sum);
                K = (K > 9) ? K / 10 : 0;
            }
            if (carry > 0)
                retList.Insert(0, carry);
            return retList;
        }
        #endregion
        #region AddStrings  
        public static string AddStrings(string num1, string num2)
        {
            StringBuilder retString = new StringBuilder();
            int len1 = num1.Length, len2 = num2.Length;
            int length = (len1 > len2) ? len1 : len2;
            int carry = 0;
            int n1, n2, sum, offset1, offset2;
            for (int i = length - 1; i >-1; i--)
            {
                offset1 = i - (length - len1);
                offset2 = i - (length - len2);              
                n1 = (offset1 > -1) ? num1[offset1] - 48 : 0;
                n2 = (offset2 > -1) ? num2[offset2] - 48 : 0;                
                sum = (n1 + n2 + carry);
                carry = sum / 10;
                retString.Insert(0, sum % 10);
            }
            if (carry > 0)
                retString.Insert(0, carry);
            return retString.ToString();
        }    
        #endregion
        
        #region PrintObjects
        public static void PrintIntArray(int[] arr)
        {
            Console.Write("[ ");
            foreach( int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("]");
        }
        #endregion
    }
}
