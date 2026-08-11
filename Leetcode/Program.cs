namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var a = solution.RemoveElement(nums, 2);

            Console.WriteLine($"Offset: {a}");

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(nums[i]);
            }

        }
    }
}
