using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _14929
    {
        static void Main()
        {
            // n <= 100000, X <= 100

            // X1 * X2 + X1 * X3 + ~ + Xn-1 * Xn  ==  X1 * (X2 + X3 + ~ + Xn) + X2 * (X3 + ~ + Xn) + ~ + Xn-1 * Xn

            long result = 0; // 결과 값
            var n = int.Parse(Console.ReadLine()); // n 입력 (3)
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // X 입력 (1 -2 3)

            var calcValues = new List<long> { nums[0] }; // 값 저장용 리스트

            for (int i = 1; i < n; i++)
                calcValues.Add(calcValues[i - 1] + nums[i]); // X(n - 1) * Xn 저장

            // calcValues = [ X1, X1 + X2, X1 + X2 + X3 ]
            // calcValues = [ 1, -1, 2 ]

            for (int i = 0; i < n; i++)
            {
                // 1. result += X1 * (X2 + X3)
                //    result += 1
                // 2. result += X2 * (X3)
                //    result += -6
                result += nums[i] * (calcValues[n - 1] - calcValues[i]);
            }

            // 결과: result = -5

            Console.WriteLine(result);
        }
    }
}
