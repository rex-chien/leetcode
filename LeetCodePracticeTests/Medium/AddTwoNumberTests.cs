using System.Linq;
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
            ListNode l1 = CreateListNodes(2, 4, 3);
            ListNode l2 = CreateListNodes(5, 6, 4);
            var sut = new AddTwoNumbers();

            // act
            var actual = sut.Solution(l1, l2);
            ListNode expected = CreateListNodes(7, 0, 8);

            // assert
            actual.ToExpectedObject().ShouldEqual(expected);
        }

        private ListNode CreateListNodes(params int[] numbers)
        {
            ListNode output = new ListNode(numbers[0]);
            ListNode currentNode = output;
            
            foreach (var n in numbers.Skip(1))
            {
                currentNode.next = new ListNode(n);
                currentNode = currentNode.next;
            }

            return output;
        }
    }
}