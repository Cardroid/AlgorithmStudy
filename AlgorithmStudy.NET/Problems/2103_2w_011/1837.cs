using System;
using System.Collections.Generic;
using System.Numerics;

namespace BAEKJOON.Problems._2103_2w
{
    class _1837
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');

            BigInteger p = BigInteger.Parse(s[0]);
            int k = int.Parse(s[1]);
            var nums = GetPNums(k);

            for (int i = 0; i < nums.Length; i++)
            {
                if (p % nums[i] == 0)
                {
                    if (nums[i] < k)
                    {
                        Console.WriteLine($"BAD {nums[i]}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"GOOD");
                        break;
                    }
                }
                else if (i == nums.Length - 1)
                    Console.WriteLine($"GOOD");
            }
        }

        static int[] GetPNums(int n)
        {
            // 에라토스테네스의 체

            if (n < 2)
                return new int[0];

            List<int> result = new List<int>();
            bool[] temp = new bool[n + 1];
            int m = (int)Math.Sqrt(n);

            // 소수는 false, 아니면 true;

            for (int i = 2; i <= n; i++)
            {
                if (i <= m && temp[i] == false)
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        temp[j] = true;
                    }
                }

                if (temp[i] == false)
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }
    }
}
