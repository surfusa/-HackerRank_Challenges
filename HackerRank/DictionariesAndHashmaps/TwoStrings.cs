using System;

namespace DictionariesAndHashmaps
{
    public class TwoStrings
    {
        /// <summary>
        /// Testing to see if a substring in the first string is contained in the second string.
        /// </summary>
        /// <param name="s">s1: first string s2: second string</param>
        /// <returns>If valid, return YES, otherwise return NO.</returns>
        public string TwoString(string s1, string s2)
        {
            string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            for (int i = 0; i <= (alphabet.Length - 1); i++)
                if (s1.Contains(alphabet[i]) == true && s2.Contains(alphabet[i]) == true)
                {
                    return ("YES");
                }
            return ("NO");
        }
    }
}
