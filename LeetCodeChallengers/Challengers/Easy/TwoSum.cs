namespace LeetCodeChallengers.Challengers.Easy
{
    internal static class TwoSum
    {
        private static int[] input = Array.Empty<int>();
        private static int target;
        private static int[] output = Array.Empty<int>();
        private static int[] result = Array.Empty<int>();

        public static void Execute()
        {
            Console.WriteLine($"Challenger: {nameof(TwoSum)}");

            #region Example 1

            input = new int[] { 2, 7, 11, 15 };
            target = 9;
            output = new int[] { 0, 1 };

            result = Test(input, target);
            PrintResult(1);

            #endregion

            #region Example 2

            input = new int[] { 3, 2, 4 };
            target = 6;
            output = new int[] { 1, 2 };

            result = Test(input, target);
            PrintResult(2);

            #endregion

            #region Example 3

            input = new int[] { 3, 3 };
            target = 6;
            output = new int[] { 0, 1 };

            result = Test(input, target);
            PrintResult(3);

            #endregion
        }

        private static int[] Test(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var n = nums[i];

                if (dict.TryGetValue(target - n, out int index))
                {
                    return new int[] { index, i };
                }

                dict.TryAdd(n, i);
            }

            return Array.Empty<int>();
        }

        public static void PrintResult(int exampleNumber)
        {
            Console.WriteLine();
            Console.WriteLine($"Example {exampleNumber}");
            Console.WriteLine("Input: [{0}]", string.Join(',', input));
            Console.WriteLine("Target: {0}", target);
            Console.WriteLine("Output: [{0}]", string.Join(',', output));
            Console.WriteLine("Result: [{0}]", string.Join(',', result));
            Console.WriteLine("Success: {0}", Enumerable.SequenceEqual(output, result));
        }
    }
}
