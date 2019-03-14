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
            GivenInputAndNumRowsShouldGet("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR");
        }
        
        [TestMethod]
        public void SolutionTest_PAYPALISHIRING_4_Rows_Should_Get_PINALSIGYAHRPI()
        {
            GivenInputAndNumRowsShouldGet("PAYPALISHIRING", 4, "PINALSIGYAHRPI");
        }
        
        [TestMethod]
        public void SolutionTest_LEETCODEPRACTICE_4_Rows_Should_Get_LDTEOECIECPACTRE()
        {
            GivenInputAndNumRowsShouldGet("LEETCODEPRACTICE", 4, "LDTEOECIECPACTRE");
        }

        private static void GivenInputAndNumRowsShouldGet(string input, int numRows, string expected)
        {
            // arrange
            var sut = new ZigZagConversion();

            // act
            string actual = sut.Solution(input, numRows);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}