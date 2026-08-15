using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Solutions
{
    internal class Leetcode_LongestSubsequenceWithNon_ZeroBitwiseXOR
    {
        /// <summary>
        /// 3702. Longest Subsequence With Non-Zero Bitwise XOR
        /// Problem: https://leetcode.com/problems/longest-subsequence-with-non-zero-bitwise-xor
        /// Submission: https://leetcode.com/submissions/detail/2107548246/
        /// </summary>
        public int LongestSubsequence(int[] nums)
        {
            int xorBuffer;
            xorBuffer = nums[0];

            int foundNonZero = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                foundNonZero |= nums[i];

                xorBuffer = xorBuffer ^ nums[i];
            }

            if (xorBuffer == 0 && foundNonZero > 0)
                return nums.Length - 1;

            if (xorBuffer > 0)
                return nums.Length;

            return 0;
        }
    }
}
