using System;
using System.Linq;

namespace BAEKJOON.Problems._2104_1w
{
    class _2858
    {
        static void Main()
        {
            int[] values = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int red = values[0]; // 빨간색 타일의 수
            int brown = values[1]; // 갈색 타일의 수

            int area = red + brown;

            // i, j 는 세로와 가로

            for (int i = 1; i < 5000; i++)
            {
                for (int j = 1; j < 5000; j++)
                {
                    if (area == i * j)
                    {
                        // 겹치는 부분 제거
                        if ((i * 2) + (j - 2) * 2 == red || (j * 2) + (i - 2) * 2 == red)
                        {
                            Console.WriteLine(i > j ? $"{i} {j}" : $"{j} {i}");
                            return;
                        }
                    }
                }
            }
        }
    }
}
