using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Solutions
{
    internal class Leetcode_FindMissingElements
    {

        /// <summary>
        /// 3731. Find Missing Elements
        /// Problem: https://leetcode.com/problems/find-missing-elements
        /// Submission: https://leetcode.com/submissions/detail/2098424452/
        /// </summary>
        public IList<int> FindMissingElements(int[] nums)
        {
            List<int> result = new List<int>();
            bool[] visited = new bool[101];

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (int num in nums)
            {
                max = Math.Max(num, max);
                min = Math.Min(num, min);

                visited[num] = true;
            }


            for (int i = min; i < max; i++)
            {
                if (!visited[i])
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
