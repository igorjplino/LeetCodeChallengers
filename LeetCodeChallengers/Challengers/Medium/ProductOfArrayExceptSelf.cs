using LeetCodeChallengers.Challengers.Easy;

namespace LeetCodeChallengers.Challengers.Medium
{
    internal static class ProductOfArrayExceptSelf
    {
        private static int[] input = Array.Empty<int>();
        private static int[] output = Array.Empty<int>();
        private static int[] result = Array.Empty<int>();

        public static void Execute()
        {
            Console.WriteLine($"Challenger: {nameof(ProductOfArrayExceptSelf)}");

            var examples = new List<Example>
            {
                new Example
                {
                    Input = new int[] { 1, 2, 3, 4 },
                    Output = new int[] { 24, 12, 8, 6 }
                },
                new Example
                {
                    Input = new int[] { -1, 1, 0, -3, 3 },
                    Output = new int[] { 0, 0, 9, 0, 0 }
                }
            };

            for (int i = 0; i < examples.Count; i++)
            {
                input = examples[i].Input;
                output = examples[i].Output;

                result = ProductExceptSelf(input);
                PrintResult(i + 1);
            }
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            return Array.Empty<int>();
        }

        public static void PrintResult(int exampleNumber)
        {
            Console.WriteLine();
            Console.WriteLine($"Example {exampleNumber}");
            Console.WriteLine("Input: [{0}]", string.Join(',', input));
            Console.WriteLine("Output: [{0}]", string.Join(',', output));
            Console.WriteLine("Result: [{0}]", string.Join(',', result));
            Console.WriteLine("Success: {0}", Enumerable.SequenceEqual(output, result));
        }

        private class Example
        {
            public int[] Input { get; set; }
            public int[] Output { get; set; }
        }
    }
}
