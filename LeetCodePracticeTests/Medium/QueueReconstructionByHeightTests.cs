using LeetCodePractice.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePracticeTests.Medium
{
    [TestClass]
    public class QueueReconstructionByHeightTests
    {
        [TestMethod]
        public void ReconstructQueueTest_1()
        {
            GivenInputShouldExpectedOutput(
                new[,] {{7, 0}, {4, 4}, {7, 1}, {5, 0}, {6, 1}, {5, 2}},
                new[,] {{5, 0}, {7, 0}, {5, 2}, {6, 1}, {4, 4}, {7, 1}});
        }

        private static void GivenInputShouldExpectedOutput(int[,] input, int[,] expected)
        {
            // arrange
            var sut = new QueueReconstructionByHeight();

            // act
            var actual = sut.ReconstructQueue(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}