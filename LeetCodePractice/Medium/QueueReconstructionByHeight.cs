using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodePractice.Medium
{
    public class QueueReconstructionByHeight
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            var output = new List<int[]>();

            var sortedPeople = people
                .OrderByDescending(p => p[0])
                .ThenBy(p => p[1])
                .ToList();
            
            foreach (var person in sortedPeople)
            {
                output.Insert(person[1], person);
            }

            return output.ToArray();
        }
    }
}