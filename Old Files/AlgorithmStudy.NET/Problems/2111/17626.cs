using System;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _17626
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int[] dp = new int[num + 1];
            dp[1] = 1;

            for (int i = 2; i <= num; i++)
            {
                int min = int.MaxValue;

                for (int j = 1; j * j <= i; j++)
                {
                    int temp = i - j * j;
                    min = Math.Min(min, dp[temp]);
                }

                dp[i] = min + 1;
            }

            Console.WriteLine($"{dp[num]}\n");
        }
    }
}
