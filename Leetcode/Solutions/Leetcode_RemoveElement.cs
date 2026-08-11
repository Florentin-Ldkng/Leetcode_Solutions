using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Solutions
{
    internal class Leetcode_RemoveElement
    {
        /// <summary>
        /// 27. Remove Element
        /// Problem: https://leetcode.com/problems/remove-element
        /// Submission: https://leetcode.com/submissions/detail/2102545185/
        /// </summary>
        public int RemoveElement(int[] nums, int val)
        {
            int offset = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[offset] = nums[i];
                    offset++;
                }
            }

            return offset;
        }
    }
}
