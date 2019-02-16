using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Tests
{
    [TestClass()]
    public class TwoSumTests
    {
        [TestMethod()]
        public void SolutionTest_nums_0_0_target_0_return_0_1()
        {
            // arrange
            TwoSum sut = new TwoSum();
            int[] nums = { 0, 0 };
            int target = 0;
            int[] expected = { 0, 1 };

            // act
            int[] actual = sut.Solution(nums, target);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}