using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation.Tests
{
    [TestClass()]
    public class MakingAnagramsTests
    {
        [TestMethod()]
        public void MakeAnagramTest1()
        {
            // Apply
            var expectedResult = 4;
            var successfulInput1 = "cde";
            var successfulInput2 = "abc";

            // Act
            var MakingAnagram = new MakingAnagrams();
            var successfulTestResult = MakingAnagram.MakeAnagram(successfulInput1, successfulInput2);

            // Assert
            Assert.AreEqual(expectedResult, successfulTestResult);
        }
        [TestMethod()]
        public void MakeAnagramTest2()
        {
            // Apply
            var expectedResult = 30;
            var successfulInput1 = "fcrxzwscanmligyxyvym";
            var successfulInput2 = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

            // Act
            var MakingAnagram = new MakingAnagrams();
            var successfulTestResult = MakingAnagram.MakeAnagram(successfulInput1, successfulInput2);

            // Assert
            Assert.AreEqual(expectedResult, successfulTestResult);
        }
        [TestMethod()]
        public void MakeAnagramTest3()
        {
            // Apply
            var expectedResult = 2;
            var successfulInput1 = "showman";
            var successfulInput2 = "woman";

            // Act
            var MakingAnagram = new MakingAnagrams();
            var successfulTestResult = MakingAnagram.MakeAnagram(successfulInput1, successfulInput2);

            // Assert
            Assert.AreEqual(expectedResult, successfulTestResult);
        }
    }
}