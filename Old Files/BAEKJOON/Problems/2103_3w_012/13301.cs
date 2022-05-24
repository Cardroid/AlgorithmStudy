using System;
using System.Collections.Generic;
using System.Linq;

namespace BAEKJOON.Problems._2103_3w
{
    class _13301
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());

            // 피보나치 수열 가져오기
            long[] array = GetFibonacci(index);
            long result = 0;

            if (index < 5)
            {
                if (index == 1)
                    Console.WriteLine(4);
                else if (index == 2)
                    Console.WriteLine(6);
                else if (index == 3)
                    Console.WriteLine(10);
                else
                    Console.WriteLine(16);
                return;
            }

            // 계산
            result += array[array.Length - 1] * 3;
            result += array[array.Length - 2] * 2;
            result += array[array.Length - 3] * 2;
            result += array[array.Length - 4];

            Console.WriteLine(result);
        }

        static long[] GetFibonacci(int count)
        {
            long num1 = 0;
            long num2 = 1;
            List<long> result = new List<long>();

            // 초기값 0과 1을 추가
            result.Add(0);
            result.Add(1);

            while (result.Count <= count)
            {
                result.Add(num1 + num2);
                num1 = num2;
                num2 = result.Last();
            }
            return result.ToArray();
        }
    }
}
