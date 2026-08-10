namespace Leetcode.Solutions
{
    internal class Leetcode_ValidParentheses
    {
        /// <summary>
        /// 20. Valid Parentheses
        /// Problem: https://leetcode.com/problems/valid-parentheses
        /// Submission: https://leetcode.com/submissions/detail/2094283005/
        /// </summary>
        public bool IsValid(string s)
        {

            Stack<char> ValidationStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    ValidationStack.Push(s[i]);
                }
                else
                {
                    if (ValidationStack.Count == 0 || s[i] != Translate(ValidationStack.Pop()))
                    {
                        return false;
                    }
                }
            }
            return ValidationStack.Count == 0;
        }

        public char Translate(char input)
        {
            switch (input)
            {
                case '[':
                    return ']';
                case '{':
                    return '}';
                case '(':
                    return ')';
            }
            return ' ';
        }
    }
}
