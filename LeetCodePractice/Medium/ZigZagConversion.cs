using System;

namespace LeetCodePractice.Medium
{
    public class ZigZagConversion
    {
        public string Solution(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            
            string[] rows = new string[numRows];
            int currentRow = 0;
            int step = 1;
            
            foreach (var c in s)
            {
                rows[currentRow] += c;

                if (currentRow == 0)
                {
                    step = 1;
                }

                if (currentRow == rows.Length - 1)
                {
                    step = -1;
                }
                
                currentRow += step;
            }
            return string.Join("", rows);
        }
    }
}