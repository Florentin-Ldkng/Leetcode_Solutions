namespace Leetcode.Solutions
{
    internal class Leetcode_FindTheIndexOfTheFirstOccurenceInAString
    {
        /// <summary>
        /// 28. Find the Index of the First Occurrence in a String
        /// Problem: https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string
        /// Submission: https://leetcode.com/submissions/detail/2102670434/
        /// </summary>
        public int StrStr(string haystack, string needle)
        {
            Dictionary<char, int> needleDict = new Dictionary<char, int>();

            bool found = false;

            for (int i = 0; i < needle.Length - 1; i++)
            {
                needleDict[needle[i]] = needle.Length - i - 1;
            }

            int j = needle.Length - 1;

            while (j < haystack.Length)
            {
                int counter = 0;

                for (int i = needle.Length - 1; i >= 0; i--)
                {
                    if (needle[i] == haystack[j - counter])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter == needle.Length)
                {
                    found = true;
                    break;
                }


                if (needleDict.ContainsKey(haystack[j]))
                {
                    j += needleDict[haystack[j]];
                }

                else
                {
                    j += needle.Length;
                }
            }

            if (found)
                return j - (needle.Length - 1);

            return -1;
        }
    }
}
