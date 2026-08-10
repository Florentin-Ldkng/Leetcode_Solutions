using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Solutions
{
    internal class Leetcode_TwoSum
    {
        /// <summary>
        /// 1. Two Sum
        /// Problem: https://leetcode.com/problems/two-sum
        /// Submission: https://leetcode.com/submissions/detail/2092536450/
        /// </summary>
        public int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> Lookup = new Dictionary<int, int>();

            int dif = 0;
            for (int i = 0; i <= nums.Length; i++)
            {
                dif = target - nums[i];

                if (Lookup.ContainsKey(dif))
                {
                    return new int[] { Lookup[dif], i };
                }

                Lookup.TryAdd(nums[i], i);
            }
            return null;
        }
    }
}
