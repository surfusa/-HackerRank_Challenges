using Microsoft.VisualStudio.TestTools.UnitTesting;
using DictionariesAndHashmaps;
using System;
using System.Collections.Generic;
using System.Text;

namespace DictionariesAndHashmaps.Tests
{
    [TestClass()]
    public class TwoStringsTests
    {
        [TestMethod()]
        public void TwoStringTest1()
        {
            //Apply
            string[] expectedSuccessfulTest = { "YES", "NO" };
            string[] successfulTestStr1 = { "hello", "hi" };
            string[] successfulTestStr2 = { "world", "world" };
            var x = 0;

            //Act
            string[] successfulResults = new string[successfulTestStr1.Length];
            var twoStrings = new TwoStrings();
            for (x = 0; x < successfulTestStr1.Length; x++)
            {
                successfulResults[x] = twoStrings.TwoString(successfulTestStr1[x], successfulTestStr2[x]);
            }
            //Assert
            bool successTest = true;
            for (x = 0; x < successfulTestStr1.Length; x++)
            {
                if (expectedSuccessfulTest[x] != successfulResults[x])
                {
                    successTest = false;
                }
            }
            Assert.IsTrue(successTest);
        }
        [TestMethod()]
        public void TwoStringTest2()
        {
            //Apply
            string[] expectedSuccessfulTest = { "NO", "YES", "YES", "NO" };
            string[] successfulTestStr1 = { "wouldyoulikefries", "hackerrankcommunity", "jackandjill", "writetoyourparents" };
            string[] successfulTestStr2 = { "abcabcabcabcabcabc", "cdecdecdecde", "wentupthehill", "fghmqzldbc" };
            var x = 0;

            //Act
            string[] successfulResults = new string[successfulTestStr1.Length];
            var twoStrings = new TwoStrings();
            for (x = 0; x < successfulTestStr1.Length; x++)
            {
                successfulResults[x] = twoStrings.TwoString(successfulTestStr1[x], successfulTestStr2[x]);
            }
            //Assert
            bool successTest = true;
            for (x = 0; x < successfulTestStr1.Length; x++)
            {
                if (expectedSuccessfulTest[x] != successfulResults[x])
                {
                    successTest = false;
                }
            }
            Assert.IsTrue(successTest);
        }
        [TestMethod()]
        public void TwoStringTest3()
        {
            //Apply
            string[] expectedSuccessfulTest = { "YES", "NO" };
            string[] successfulTestStr1 = { "aardvark", "beetroot" };
            string[] successfulTestStr2 = { "apple", "sandals" };
            var x = 0;

            //Act
            string[] successfulResults = new string[successfulTestStr1.Length];
            var twoStrings = new TwoStrings();
            for (x = 0; x < successfulTestStr1.Length; x++)
            {
                successfulResults[x] = twoStrings.TwoString(successfulTestStr1[x], successfulTestStr2[x]);
            }
            //Assert
            bool successTest = true;
            for (x = 0; x < successfulTestStr1.Length; x++)
            {
                if (expectedSuccessfulTest[x] != successfulResults[x])
                {
                    successTest = false;
                }
            }
            Assert.IsTrue(successTest);
        }
    }
}