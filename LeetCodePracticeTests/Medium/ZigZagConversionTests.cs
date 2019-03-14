using LeetCodePractice.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePracticeTests.Medium
{
    [TestClass]
    public class ZigZagConversionTests
    {
        [TestMethod]
        public void SolutionTest_PAYPALISHIRING_3_Rows_Should_Get_PAHNAPLSIIGYIR()
        {
            // arrange
            string input = "PAYPALISHIRING";
            int numRows = 3;
            string expected = "PAHNAPLSIIGYIR";
            var sut = new ZigZagConversion();
            
            // act
            string actual = sut.Solution(input, numRows);
            
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}