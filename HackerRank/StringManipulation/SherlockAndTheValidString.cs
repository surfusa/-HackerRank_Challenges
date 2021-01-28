using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace StringManipulation
{
    public class SherlockAndTheValidString
    {
        /// <summary>
        /// A string is valid if all characters of the string appear the same number of times. It is also valid if one character removed in the string makes it valid.
        /// </summary>
        /// <param name="s">s: string being tested</param>
        /// <returns>If valid, return YES, otherwise return NO.</returns>
        public string IsValid(string s)
        {
            int counter = 0, x = 0, temp = 0;
            bool oneCharacterRemoved = false, switched = false;
            char[] ALPHABET = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] letterCount = new int[26];
            for (counter = 0; counter < s.Length; counter++)
            {
                for (x = 0; x < ALPHABET.Length; x++)
                {
                    if (s[counter].Equals(ALPHABET[x]) == true)
                    {
                        letterCount[x]++;
                    }
                }
            }
            counter = letterCount.Max();
            for (x = 0; x < letterCount.Length; x++)
            {
                if (counter == letterCount[x])
                {
                    temp++;
                }
                if (letterCount[x] != counter && letterCount[x] != 0)
                {
                    if (letterCount[x] + 1 == counter && switched == false && oneCharacterRemoved == true && temp <= 1)
                    {
                        counter = letterCount[x];
                        switched = true;
                        if (temp == 0)
                        {
                            oneCharacterRemoved = false;
                        }
                    }
                    else if (oneCharacterRemoved == true)
                    {
                        return "NO";
                    }
                    else if (letterCount[x] + 1 == counter || letterCount[x] - 1 == counter)
                            {
                        oneCharacterRemoved = true;
                    }
                    else if (letterCount[x] - 1 == 0)
                    {
                        oneCharacterRemoved = true;
                    }
                    else
                    {
                        return "NO";
                    }

                }
            }
            return "YES";
        }
    }
}
