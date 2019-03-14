using ExpectedObjects;
using LeetCodePractice;
using LeetCodePractice.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePracticeTests.Medium
{
    [TestClass]
    public class AddTwoNumberTests
    {
        [TestMethod]
        public void SolutionTest_l1_2_4_3_l2_5_6_4_Output_7_0_8()
        {
            // arrange
            ListNode l1 = new ListNode(2) {next = new ListNode(4) {next = new ListNode(3)}};
            ListNode l2 = new ListNode(5) {next = new ListNode(6) {next = new ListNode(4)}};
            var sut = new AddTwoNumbers();

            // act
            var actual = sut.Solution(l1, l2);
            ListNode expected = new ListNode(7) {next = new ListNode(0) {next = new ListNode(8)}};

            // assert
            actual.ToExpectedObject().ShouldEqual(expected);
        }
    }
}