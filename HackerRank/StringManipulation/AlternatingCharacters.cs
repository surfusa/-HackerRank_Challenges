using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation
{
        /// <summary>
        /// Counts how many deletions must be made to make a string alternating
        /// </summary>
        /// <param name="s">s: string being tested that only contains As and Bs</param>
        /// <returns>Number of </returns>
    public class AlternatingCharacters
    {
        public int alternatingChar (string s)
        {
            int counter = 0;
            for (int i = 0; i < (s.Length - 1); i++)
            {
                if (s[i] == s[i + 1])
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
