using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Tests
{
    [TestClass()]
    public class TwoDArrayDSTests
    {
        [TestMethod()]
        public void GetLargestHourGlassValueTest_Success1()
        {
            // Arrange
            var expectedSuccessfulTest = 19;
            var successfulTestStr = "1 1 1 0 0 0\n0 1 0 0 0 0\n1 1 1 0 0 0\n0 0 2 4 4 0\n0 0 0 2 0 0\n0 0 1 2 4 0";
            var successfulTestInputSplit = successfulTestStr.Split('\n');
            int[][] successfulTest = new int[6][];
            for (int i = 0; i < 6; i++) {
                successfulTest[i] = Array.ConvertAll(successfulTestInputSplit[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            // Act
            var twoDArrayDS = new TwoDArrayDS();
            var successfulTestResult = twoDArrayDS.GetLargestHourGlassValue(successfulTest);

            // Assert
            Assert.AreEqual(expectedSuccessfulTest, successfulTestResult);
        }

        [TestMethod()]
        public void GetLargestHourGlassValueTest_Success2()
        {
            // Arrange
            var expectedSuccessfulTest = 13;
            var successfulTestStr = "1 1 1 0 0 0\n0 1 0 0 0 0\n1 1 1 0 0 0\n0 9 2 -4 -4 0\n0 0 0 -2 0 0\n0 0 -1 -2 -4 0";
            var successfulTestInputSplit = successfulTestStr.Split('\n');
            int[][] successfulTest = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                successfulTest[i] = Array.ConvertAll(successfulTestInputSplit[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            // Act
            var twoDArrayDS = new TwoDArrayDS();
            var successfulTestResult = twoDArrayDS.GetLargestHourGlassValue(successfulTest);

            // Assert
            Assert.AreEqual(expectedSuccessfulTest, successfulTestResult);
        }

        [TestMethod()]
        public void GetLargestHourGlassValueTest_Success3()
        {
            // Arrange
            var expectedSuccessfulTest = 28;
            var successfulTestStr = "-9 -9 -9 1 1 1\n0 -9 0 4 3 2\n-9 -9 -9 1 2 3\n0 0 8 6 6 0\n0 0 0 -2 0 0\n0 0 1 2 4 0";
            var successfulTestInputSplit = successfulTestStr.Split('\n');
            int[][] successfulTest = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                successfulTest[i] = Array.ConvertAll(successfulTestInputSplit[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            // Act
            var twoDArrayDS = new TwoDArrayDS();
            var successfulTestResult = twoDArrayDS.GetLargestHourGlassValue(successfulTest);

            // Assert
            Assert.AreEqual(expectedSuccessfulTest, successfulTestResult);
        }
    }
}