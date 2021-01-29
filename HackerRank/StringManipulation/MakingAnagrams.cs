using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation
{
        /// <summary>
        /// Determing the minimum number of letters to delete in two strings to make them anagrams 
        /// </summary>
        /// <param name="s">a: first string b: second string</param>
        /// <returns>Number of deletions required</returns>
    public class MakingAnagrams
    {
        public int MakeAnagram(string a, string b)
        {
            int valid = 0;
            for (int i = 0; i < (a.Length); i++)
            {
                if (b.IndexOf(a[i], 0) != -1)
                {
                    b = b.Remove((b.IndexOf(a[i])), 1);
                    valid++;
                }

            }
            return (b.Length + a.Length - valid);

        }

    }
}
