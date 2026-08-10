using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Solutions
{
    internal class Leetcode_PalindromeNumber
    {
        /// <summary>
        /// 9. Palindrome Number
        /// Problem: https://leetcode.com/problems/palindrome-number
        /// Submission: https://leetcode.com/submissions/detail/2093777031/
        /// </summary>
        public bool IsPalindrome(int x)
        {
            char[] palindromeArray = x.ToString().ToCharArray();

            for (int i = 0; i < (palindromeArray.Length - (palindromeArray.Length % 2)) / 2; i++)
            {
                if (palindromeArray[i] != palindromeArray[(palindromeArray.Length - 1) - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
