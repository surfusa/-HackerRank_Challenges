using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation.Tests
{
    [TestClass()]
    public class SherlockAndTheValidStringTests
    {
        [TestMethod()]
        public void IsValidTest1()
        {
            //Apply
            var expectedResult = "NO";
            var successfulInput = "aabbcd";

            //Act
            var SatVS = new SherlockAndTheValidString();
            var successfulResult = SatVS.IsValid(successfulInput);
            //Assert
            Assert.AreEqual(expectedResult, successfulResult);
        }
        [TestMethod()]
        public void IsValidTest2()
        {
            //Apply
            var expectedResult = "NO";
            var successfulInput = "aabbccddeefghi";

            //Act
            var SatVS = new SherlockAndTheValidString();
            var successfulResult = SatVS.IsValid(successfulInput);
            //Assert
            Assert.AreEqual(expectedResult, successfulResult);
        }
        [TestMethod()]
        public void IsValidTest3()
        {
            //Apply
            var expectedResult = "YES";
            var successfulInput = "abcdefghhgfedecba";

            //Act
            var SatVS = new SherlockAndTheValidString();
            var successfulResult = SatVS.IsValid(successfulInput);
            //Assert
            Assert.AreEqual(expectedResult, successfulResult);
        }
    }
}