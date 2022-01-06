using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _14929
    {
        static void Main()
        {
            long result = 0;
            var n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var calcValues = new List<long> { nums[0] };

            for (int i = 1; i < n; i++)
                calcValues.Add(calcValues[i - 1] + nums[i]);

            for (int i = 0; i < n; i++)
                result += nums[i] * (calcValues[n - 1] - calcValues[i]);

            Console.WriteLine(result);
        }
    }
}
