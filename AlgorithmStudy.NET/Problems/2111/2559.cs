using System;
using System.Linq;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _2559
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');
            int len = int.Parse(temp[0]);
            int date = int.Parse(temp[1]);

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int max = int.MinValue;

            int sum = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                count++;

                if (count == date)
                {
                    max = Math.Max(max, sum);
                    sum -= nums[i - date + 1];
                    count--;
                }
            }

            Console.WriteLine(max);
        }
    }
}
