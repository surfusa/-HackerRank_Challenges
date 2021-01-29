using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation.Tests
{
    [TestClass()]
    public class AlternatingCharactersTests
    {
        [TestMethod()]
        public void alternatingCharTest1()
        {
            //Apply
            var expectedResult = new int[] { 3, 4, 0, 0, 4 };
            string[] successfulInput = { "AAAA", "BBBBB", "ABABABAB", "BABABA", "AAABBB" };

            //Act
            var alternatingCharacter = new AlternatingCharacters();
            int[] successfulResult = new int[5];
            for (int x = 0; x < 5; x++)
            {
                successfulResult[x] = alternatingCharacter.alternatingChar(successfulInput[x]);
            }

            //Assert
            bool successCheck = true;
            for (int x = 0; x < 5; x++)
            {
                if(expectedResult[x] != successfulResult[x])
                {
                    successCheck = false;
                }
            }
            Assert.IsTrue(successCheck);
        }
        [TestMethod()]
        public void alternatingCharTest2()
        {
            //Apply
            var expectedResult = new int[] { 6, 4, 1 };
            string[] successfulInput = { "AAABBBAABB", "AABBAABB", "ABABABAA" };

            //Act
            var alternatingCharacter = new AlternatingCharacters();
            int[] successfulResult = new int[3];
            for (int x = 0; x < 3; x++)
            {
                successfulResult[x] = alternatingCharacter.alternatingChar(successfulInput[x]);
            }

            //Assert
            bool successCheck = true;
            for (int x = 0; x < 3; x++)
            {
                if (expectedResult[x] != successfulResult[x])
                {
                    successCheck = false;
                }
            }
            Assert.IsTrue(successCheck);
        }
        [TestMethod()]
        public void alternatingCharTest3()
        {
            //Apply
            var expectedResult = new int[] { 3 };
            string[] successfulInput = { "ABBABBAA" };

            //Act
            var alternatingCharacter = new AlternatingCharacters();
            int[] successfulResult = new int[1];
            for (int x = 0; x < 1; x++)
            {
                successfulResult[x] = alternatingCharacter.alternatingChar(successfulInput[x]);
            }

            //Assert
            bool successCheck = true;
            for (int x = 0; x < 1; x++)
            {
                if (expectedResult[x] != successfulResult[x])
                {
                    successCheck = false;
                }
            }
            Assert.IsTrue(successCheck);
        }
    }
}