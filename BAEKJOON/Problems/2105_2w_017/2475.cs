using System;
using System.Linq;

namespace BAEKJOON.Problems._2105_2w
{
    class _2475
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i] * nums[i];
            }

            result %= 10;

            Console.WriteLine(result);
        }
    }
}
