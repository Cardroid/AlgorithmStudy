using System;

namespace BAEKJOON.Problems._2105_1w
{
    class _19532
    {
        static void Main()
        {
            string[] tempArray = Console.ReadLine().Split();

            int a, b, c, d, e, f;

            a = int.Parse(tempArray[0]);
            b = int.Parse(tempArray[1]);
            c = int.Parse(tempArray[2]);
            d = int.Parse(tempArray[3]);
            e = int.Parse(tempArray[4]);
            f = int.Parse(tempArray[5]);

            for (int i = -999; i < 1000; i++)
            {
                for (int j = -999; j < 1000; j++)
                {
                    if ((a * i) + (b * j) == c && (d * i) + (e * j) == f)
                        Console.WriteLine($"{i} {j}");
                }
            }
        }
    }
}
