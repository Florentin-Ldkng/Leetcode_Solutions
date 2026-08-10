namespace Leetcode.Solutions
{
    internal class Leetcode_FizzBuzz
    {
        /// <summary>
        /// 412. Fizz Buzz
        /// Problem: https://leetcode.com/problems/fizz-buzz
        /// Submission: https://leetcode.com/submissions/detail/2092552841/
        /// </summary>
        public IList<string> FizzBuzz(int n)
        {
            List<string> Result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string output = "";

                if (i % 3 == 0)
                {
                    output = "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }
                if (String.IsNullOrEmpty(output))
                {
                    output = i.ToString();
                }
                Result.Add(output);
            }

            return Result;

        }
    }
}
