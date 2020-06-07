using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region DefangIPaddr Testing
        public static void DefangIPaddrTest()
        {
            Console.WriteLine("1[.]1[.]1[.]1" == DefangIPaddr("1.1.1.1"));
            Console.WriteLine("255[.]100[.]50[.]0" == DefangIPaddr("255.100.50.0"));
            Console.WriteLine("1[.]1[.]1[.]1" == DefangIPaddr2("1.1.1.1"));
            Console.WriteLine("255[.]100[.]50[.]0" == DefangIPaddr2("255.100.50.0"));
            Console.WriteLine("1[.]1[.]1[.]1" == DefangIPaddr("1.1.1.1"));
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
            char[] nuIp = new char[address.Length + 6];
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


    }
}
