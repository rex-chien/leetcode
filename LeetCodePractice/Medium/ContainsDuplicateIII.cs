using System;

namespace LeetCodePractice.Medium
{
    public class ContainsDuplicateIII
    {
        /// <summary>
        /// Given an array of integers,
        /// find out whether there are two distinct indices i and j in the array
        /// such that the absolute difference between nums[i] and nums[j] is at most t
        /// and the absolute difference between i and j is at most k.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                
                
                for (var j = i + 1; j < nums.Length && j <= i + k; j++)
                {
                    var num1 = nums[i];
                    var num2 = nums[j];

                    if (Math.Abs((long)num1 - num2) <= t)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}