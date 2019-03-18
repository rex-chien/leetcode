using LeetCodePractice.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePracticeTests.Medium
{
    [TestClass]
    public class QueueReconstrunctionByHeightTests
    {
        [TestMethod]
        public void ReconstructQueueTest_()
        {
            // arrange
            var sut = new QueueReconstrunctionByHeight();
            var input = new[,] {{7, 0}, {4, 4}, {7, 1}, {5, 0}, {6, 1}, {5, 2}};
            var expected = new[,] {{5, 0}, {7, 0}, {5, 2}, {6, 1}, {4, 4}, {7, 1}};

            // act
            var actual = sut.ReconstructQueue(input);
            
            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}