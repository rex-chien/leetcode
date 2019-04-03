using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodePractice.Medium
{
    public class QueueReconstructionByHeight
    {
        public int[,] ReconstructQueue(int[,] people)
        {
            var output = new int[people.GetLength(0), 2];

            var tuples = Enumerable.Range(0, people.GetLength(0))
                .Select(i => new Tuple<int, int>(people[i, 0], people[i, 1]));
            var sortedTuples = tuples.OrderByDescending(t => t.Item1).ThenBy(t => t.Item2);
            var resultTuples = new List<Tuple<int, int>>();
            
            foreach (var tuple in sortedTuples)
            {
                resultTuples.Insert(tuple.Item2, tuple);
            }
            
            for (var i = 0; i < resultTuples.Count; i++)
            {
                var tuple = resultTuples[i];
                output[i, 0] = tuple.Item1;
                output[i, 1] = tuple.Item2;
            }

            return output;
        }
    }
}