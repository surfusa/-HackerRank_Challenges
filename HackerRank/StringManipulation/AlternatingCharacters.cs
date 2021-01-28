using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation
{
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
