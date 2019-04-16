using LeetCodePractice.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePracticeTests.Medium
{
    [TestClass]
    public class ContainsDuplicateIIITests
    {
        [TestMethod]
        public void ReconstructQueueTest_1()
        {
            // arrange
            var sut = new ContainsDuplicateIII();
            var nums = new[] {1, 2, 3, 1};
            var k = 3;
            var t = 0;
            var expected = true;

            // act
            var actual = sut.ContainsNearbyAlmostDuplicate(nums, k, t);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}