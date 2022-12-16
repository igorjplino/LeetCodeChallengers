using System.Collections.Generic;

namespace LeetCodeChallengers.Challengers.Easy
{
    internal static class BestTimeToBuyAndSellStock
    {
        private static int[] input = Array.Empty<int>();
        private static int expected;
        private static int output;

        public static void Execute()
        {
            Console.WriteLine($"Challenger: {nameof(BestTimeToBuyAndSellStock)}");

            #region Example 1

            input = new int[] { 7, 1, 5, 3, 6, 4 };
            expected = 5;

            output = MaxProfit(input);
            PrintResult(1);

            #endregion

            #region Example 3

            input = new int[] { 7, 6, 4, 3, 1 };
            expected = 0;

            output = MaxProfit(input);
            PrintResult(2);

            #endregion

            #region Example 3

            input = new int[] { 2, 4, 1 };
            expected = 2;

            output = MaxProfit(input);
            PrintResult(3);

            #endregion

            #region Example 4

            input = new int[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0, 9 };
            expected = 9;

            output = MaxProfit(input);
            PrintResult(4);

            #endregion
        }

        private static int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < prices.Length; i++)
            {
                min = Math.Min(min, prices[i]);
                max = Math.Max(max, prices[i] - min);
            }

            return max;
        }

        private static int MaxProfit2(int[] prices)
        {
            int left = 0;
            int right = 1;
            int maxProfit = 0;

            while (right < prices.Length)
            {
                if (prices[left] < prices[right])
                {
                    maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
                }
                else
                {
                    left = right;
                }

                right++;
            }

            return maxProfit;
        }

        private static void PrintResult(int exampleNumber)
        {
            Console.WriteLine();
            Console.WriteLine($"Example {exampleNumber}");
            Console.WriteLine("Input: [{0}]", string.Join(',', input));
            Console.WriteLine("Expected: {0}", string.Join(',', expected));
            Console.WriteLine("Output: {0}", string.Join(',', output));
            Console.WriteLine("Success: {0}", expected == output);
        }
    }
}
