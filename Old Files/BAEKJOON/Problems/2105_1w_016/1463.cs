using System;

namespace BAEKJOON.Problems._2105_1w
{
    class _1463
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int result = 0;

            if (N > 3)
            {
                result += N % 3;
                N -= N % 3;

                while (N % 3 == 0)
                {
                    result++;
                    N /= 3;
                }
            }

            while (N % 2 == 0)
            {
                result++;
                N >>= 1;
            }

            while (N > 1)
            {
                result++;
                N--;
            }

            Console.WriteLine(result);
        }
    }
}
