using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation
{
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
