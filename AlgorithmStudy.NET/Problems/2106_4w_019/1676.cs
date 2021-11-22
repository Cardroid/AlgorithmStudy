using System;

namespace AlgorithmStudy.Problems._2106_4w_019
{
    class _1676
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int n2 = 0;
            int n5 = 0;

            for (int i = 2; i <= N; i *= 2)
                n2 += N / i;

            for (int i = 5; i <= N; i *= 5)
                n5 += N / i;

            Console.WriteLine(Math.Min(n2, n5));
        }
    }
}
