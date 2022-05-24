using System;
using System.Linq;
using System.Text;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _11441
    {
        static void Main()
        {
            string[] temp;
            int len = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sums = new int[nums.Length + 1];
            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < len; i++)
                sums[i + 1] = sums[i] + nums[i];

            StringBuilder stringBuilder = new();

            for (int i = 0; i < testCase; i++)
            {
                temp = Console.ReadLine().Split(' ');
                int start = int.Parse(temp[0]);
                int end = int.Parse(temp[1]);
                stringBuilder.Append(sums[end] - sums[start - 1]);
                stringBuilder.AppendLine();
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
