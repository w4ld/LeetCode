using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region UniqueMorseRepresentations Testing
        public static void UniqueMorseRepresentationsTest()
        {
            string[] words = { "gin", "zen", "gig", "msg" };
            Console.WriteLine(2 == UniqueMorseRepresentations(words));
            string[] words2 = { "hello", "world", "a", "bee"};
            Console.WriteLine(4 == UniqueMorseRepresentations(words2));
        }
        #endregion
        #region UniqueMorseRepresentations
        public static int UniqueMorseRepresentations(string[] words)
        {
            var morseWordSet = new HashSet<string>();
            string[] morseAlphabet = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            foreach (string word in words)
            {
                StringBuilder morse_word = new StringBuilder();
                foreach (char letter in word)
                    morse_word.Append(morseAlphabet[((int)letter) - 97]);
                morseWordSet.Add(morse_word.ToString());
            }
            return morseWordSet.Count;
        }
        #endregion
    }
    
}
