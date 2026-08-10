using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Solutions
{
    internal class Leetcode_RomanToInteger
    {
        /// <summary>
        /// 13. Roman to Integer
        /// Problem: https://leetcode.com/problems/roman-to-integer
        /// Submission: https://leetcode.com/submissions/detail/2093844294/
        /// </summary>
        public int RomanToInt(string s)
        {
            int result = 0;
            int lastValue = 0;
            Dictionary<char, int> RomanPairs = new Dictionary<char, int>()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int pair = RomanPairs[s[i]];

                if (pair < lastValue)
                {
                    result -= pair;
                }
                else
                {
                    result += pair;
                }

                lastValue = pair;
            }

            return result;
        }
    }
}
