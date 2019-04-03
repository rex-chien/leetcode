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
                new[]
                {
                    new[] {7, 0}, new[] {4, 4}, new[] {7, 1}, new[] {5, 0}, new[] {6, 1}, new[] {5, 2}
                },
                new[]
                {
                    new[] {5, 0}, new[] {7, 0}, new[] {5, 2}, new[] {6, 1}, new[] {4, 4}, new[] {7, 1}
                });
        }

        [TestMethod]
        public void ReconstructQueueTest_2()
        {
            GivenInputShouldExpectedOutput(
                new[]
                {
                    new[] {6, 2}, new[] {8, 0}, new[] {3, 3}, new[] {4, 0}, new[] {4, 5}, new[] {6, 0}, new[] {7, 1}
                },
                new[]
                {
                    new[] {4, 0}, new[] {6, 0}, new[] {8, 0}, new[] {3, 3}, new[] {6, 2}, new[] {7, 1}, new[] {4, 5}
                });
        }

        [TestMethod]
        public void ReconstructQueueTest_3()
        {
            GivenInputShouldExpectedOutput(
                new[]
                {
                    new[] {5, 0}, new[] {6, 0}, new[] {3, 4}, new[] {2, 1}, new[] {2, 3}, new[] {4, 1}, new[] {5, 2},
                    new[] {3, 0}
                },
                new[]
                {
                    new[] {3, 0}, new[] {2, 1}, new[] {5, 0}, new[] {2, 3}, new[] {4, 1}, new[] {6, 0}, new[] {3, 4},
                    new[] {5, 2}
                });
        }


        private static void GivenInputShouldExpectedOutput(int[][] input, int[][] expected)
        {
            // arrange
            var sut = new QueueReconstructionByHeight();

            // act
            var actual = sut.ReconstructQueue(input);

            // assert
            for (var i = 0; i < actual.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}