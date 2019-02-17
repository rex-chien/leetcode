using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Tests
{
    [TestClass]
    public class TwoSumTests
    {
        private TwoSum sut;

        [TestInitialize]
        public void Initialize()
        {
            sut = new TwoSum();
        }

        [TestMethod]
        public void SolutionTest_nums_0_0_target_0_return_0_1()
        {
            // arrange
            int[] nums = { 0, 0 };
            int target = 0;
            int[] expected = { 0, 1 };

            // act

            // assert
            GivenNumsAndTargetShouldEqual(nums, target, expected);
        }

        [TestMethod]
        public void SolutionTest_nums_1_2_target_3_return_0_1()
        {
            // arrange
            int[] nums = { 1, 2 };
            int target = 3;
            int[] expected = { 0, 1 };

            // act

            // assert
            GivenNumsAndTargetShouldEqual(nums, target, expected);
        }

        public void GivenNumsAndTargetShouldEqual(int[] nums, int target, int[] expected)
        {
            // arrange

            // act
            int[] actual = sut.Solution(nums, target);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}