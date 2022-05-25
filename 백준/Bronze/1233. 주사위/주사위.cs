using System;
using System.Linq;

namespace BAEKJOON.Problems._2105_2w_017
{
    class _1233
    {
        static void Main()
        {
            int[] diceNums = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            int[] resultList = new int[81];

            for (int i = 1; i <= diceNums[0]; i++)
                for (int j = 1; j <= diceNums[1]; j++)
                    for (int k = 1; k <= diceNums[2]; k++)
                        resultList[i + j + k]++;

            int max = 0;
            int index = 0;

            for (int i = 0; i < 81; i++)
            {
                if (max < resultList[i])
                {
                    max = resultList[i];
                    index = i;
                }
            }

            Console.WriteLine(index);
        }
    }
}
