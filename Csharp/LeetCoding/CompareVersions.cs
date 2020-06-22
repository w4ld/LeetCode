using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region CompareVersion Testing
        public static void CompareVersionTest()
        {


            Console.WriteLine( 1 == CompareVersion("1.0", "0.1"));
            Console.WriteLine( 1 == CompareVersion("0.1.0", "0.1"));
            Console.WriteLine( -1 == CompareVersion("0.0.1", "0.1"));
            Console.WriteLine( 0 == CompareVersion("1.1", "1.1"));
            Console.WriteLine( 1 == CompareVersion("1.1", "1"));
            Console.WriteLine( 0 == CompareVersion("1.0", "1"));
            
        }
        #endregion
        #region CompareVersion
        public static int CompareVersion(string version1, string version2)
        {
            string[] vInts1 = version1.Split('.');
            int vIntLen1 = vInts1.Length;
            string[] vInts2 = version2.Split('.');
            int vIntLen2 = vInts2.Length;
            int vLen = (vIntLen1 > vIntLen2) ? vIntLen1 : vIntLen2;
            double order = Math.Pow(10, vLen);
            double vv1 = 0, vv2 = 0;
            for (int i = 0; i < vLen; i++)
            {
                int v1 = (vIntLen1 > i) ? int.Parse(vInts1[i]) : 0;
                int v2 = (vIntLen2 > i) ? int.Parse(vInts2[i]) : 0;
                vv1 += order * v1;
                vv2 += order * v2;
                order /= 10;
            }
            if (vv1 > vv2)
                return 1;
            else if (vv1 < vv2)
                return -1;
            else
                return 0;
        }
            //Console.WriteLine($"v1={v1}\tv2={v2}\t\tord:{order}");
            //Console.WriteLine($"countoff1={i - off1}\t\tcountoff2={i - off2}");

            //  Console.WriteLine($"str1:{version1}    str2:{version2}");
            //  Console.WriteLine($"vv1:{vv1}    vv2:{vv2}");
        
    }
    #endregion
}
