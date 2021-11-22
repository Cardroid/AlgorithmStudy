using System;
using System.Linq;

namespace BAEKJOON.Problems._2103_3w
{
    class _2167
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            int[,] array = new int[int.Parse(s[0]), int.Parse(s[1])];

            // 입력 값으로 배열 생성
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = row[j];
                }
            }

            int sumLength = int.Parse(Console.ReadLine());
            for (int sumCount = 0; sumCount < sumLength; sumCount++)
            {
                // 배열은 index가 0부터 시작하므로 i, j, x, y 값에 각각 -1
                string[] kValue = Console.ReadLine().Split(' ');
                int i = int.Parse(kValue[0]) - 1;
                int j = int.Parse(kValue[1]) - 1;
                int x = int.Parse(kValue[2]) - 1;
                int y = int.Parse(kValue[3]) - 1;
                int result = 0;

                // 계산
                for (int si = i; si <= x; si++)
                {
                    for (int ei = j; ei <= y; ei++)
                    {
                        result += array[si, ei];
                    }
                }

                // 출력
                Console.WriteLine(result);
            }
        }
    }
}
