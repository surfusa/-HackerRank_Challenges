using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Tests
{
    [TestClass()]
    public class LeftRotationTests
    {
        [TestMethod()]
        public void SuccessfulrotLeftTest1()
        {
            //Apply
            int[] expectedResult = { 5, 1, 2, 3, 4 };
            int[] successfulInput1 = { 5, 4 };
            int[] successfulInput2 = { 1, 2, 3, 4, 5 };



            //Act
            var LeftRotate = new LeftRotation();
            var successfulTestResult = LeftRotate.rotLeft(successfulInput2, successfulInput1[1]);


            //Assert
            bool success = true;
            for (int x = 0; x < expectedResult.Length; x++)
            {
                if (expectedResult[x] != successfulTestResult[x])
                {
                    success = false;
                }
            }
            Assert.IsTrue(success);
        }
        [TestMethod()]
        public void SuccessfulrotLeftTest2()
        {
            //Apply
            int[] expectedResult = { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 };
            int[] successfulInput1 = { 20, 10 };
            int[] successfulInput2 = { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 };



            //Act
            var LeftRotate = new LeftRotation();
            var successfulTestResult = LeftRotate.rotLeft(successfulInput2, successfulInput1[1]);


            //Assert
            bool success = true;
            for (int x = 0; x < expectedResult.Length; x++)
            {
                if (expectedResult[x] != successfulTestResult[x])
                {
                    success = false;
                }
            }
            Assert.IsTrue(success);
        }
        [TestMethod()]
        public void SuccessfulrotLeftTest3()
        {
            //Apply
            int[] expectedResult = { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 };
            int[] successfulInput1 = { 15, 13 };
            int[] successfulInput2 = { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 };



            //Act
            var LeftRotate = new LeftRotation();
            var successfulTestResult = LeftRotate.rotLeft(successfulInput2, successfulInput1[1]);


            //Assert
            bool success = true;
            for (int x = 0; x < expectedResult.Length; x++)
            {
                if (expectedResult[x] != successfulTestResult[x])
                {
                    success = false;
                }
            }
            Assert.IsTrue(success);
        }
    }
}