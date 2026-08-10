using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Solutions
{
    internal class Leetcode_RemoveDuplicates
    {
        /// <summary>
        /// 26. Remove Duplicates from Sorted Array
        /// Problem: https://leetcode.com/problems/remove-duplicates-from-sorted-array
        /// Submission: https://leetcode.com/submissions/detail/2101215242/
        /// </summary>
        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            int lastNumber = 101;

            for (int i = 0; i < nums.Length; i++)
            {
                if (lastNumber != nums[i])
                {
                    k++;
                    lastNumber = nums[i];
                    nums[k - 1] = lastNumber;
                }
            }


            return k;
        }
    }
}
