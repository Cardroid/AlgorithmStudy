using System;
using System.Linq;

namespace BAEKJOON.Problems._2103_2w
{
    class _14888
    {
        static void Main()
        {
            int numCount = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int[] operators = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            int max = -1000000000;
            int min = 1000000000;

            Cal(1, numCount, nums[0], nums, operators, ref max, ref min);

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadLine();
        }

        static void Cal(int index, int count, int sum, int[] nums, int[] operators, ref int max, ref int min)
        {
            if (index == count)
            {
                max = Math.Max(max, sum);
                min = Math.Min(min, sum);
                return;
            }

            if (operators[0] > 0)
            {
                var tempOp = ArrayCopy(operators);
                tempOp[0]--;
                Cal(index + 1, count, sum + nums[index], nums, tempOp, ref max, ref min);
            }
            if (operators[1] > 0)
            {
                var tempOp = ArrayCopy(operators);
                tempOp[1]--;
                Cal(index + 1, count, sum - nums[index], nums, tempOp, ref max, ref min);
            }
            if (operators[2] > 0)
            {
                var tempOp = ArrayCopy(operators);
                tempOp[2]--;
                Cal(index + 1, count, sum * nums[index], nums, tempOp, ref max, ref min);
            }
            if (operators[3] > 0)
            {
                var tempOp = ArrayCopy(operators);
                tempOp[3]--;
                Cal(index + 1, count, sum / nums[index], nums, tempOp, ref max, ref min);
            }
        }

        static T[] ArrayCopy<T>(T[] array) where T : IConvertible
        {
            var result = (T[])Array.CreateInstance(typeof(T), array.Length);
            Array.Copy(array, result, array.Length);
            return result;
        }
    }
}
