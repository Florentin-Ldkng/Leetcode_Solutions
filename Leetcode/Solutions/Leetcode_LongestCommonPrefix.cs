namespace Leetcode.Solutions
{
    internal class Leetcode_LongestCommonPrefix
    {
        /// <summary>
        /// 14. Longest Common Prefix
        /// Problem: https://leetcode.com/problems/longest-common-prefix
        /// Submission: https://leetcode.com/submissions/detail/2094066864/
        /// </summary>
        public string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].StartsWith(prefix) == false && prefix.Length > 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }

            return prefix;
        }
    }
}
