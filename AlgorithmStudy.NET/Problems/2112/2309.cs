using System;
using System.Collections.Generic;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _2309
    {
        static void Main()
        {
            List<int> nums = new();
            int sum = 0;

            for (int i = 0; i < 9; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
                sum += nums[i];
            }

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (sum - (nums[i] + nums[j]) == 100)
                    {
                        var temp = nums[j];
                        nums.Remove(nums[i]);
                        nums.Remove(temp);
                        break;
                    }
                }
            }

            nums.Sort();

            for (int i = 0; i < nums.Count; i++)
                Console.WriteLine(nums[i]);
        }
    }
}
