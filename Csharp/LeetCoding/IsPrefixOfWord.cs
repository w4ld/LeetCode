using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        public static int IsPrefixOfWord(string sentence, string searchWord)
        {
            string[] words = sentence.Split(" ");
            int j;
            for (int i = 0; i < words.Length; i++)
            {
                if (searchWord.Length <= words[i].Length)
                {
                    j = 0;
                    while (words[i][j] == searchWord[j])
                    {
                        j++;
                        if (j == searchWord.Length)
                            return i + 1;
                    }
                }

            }
            return -1;
        }

        #region ReverseString Testing
        public static void IsPrefixOfWordTest()
        {
            Console.WriteLine(IsPrefixOfWord("hello world", "wor")==2);            
            Console.WriteLine(IsPrefixOfWord("hello world", "or")==-1);            
            Console.WriteLine(IsPrefixOfWord("i love eating burgers","burg")==4);          
            Console.WriteLine(IsPrefixOfWord("i think youre special", "yo")==3);            
        }
            #endregion
    }
}