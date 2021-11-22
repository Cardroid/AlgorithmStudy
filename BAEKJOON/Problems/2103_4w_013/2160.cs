using System;
using System.Linq;

namespace BAEKJOON.Problems._2103_4w
{
    class _2160
    {
        static void Main()
        {
            int totalArtLength = int.Parse(Console.ReadLine());

            int[][,] ArtArray = new int[totalArtLength][,];

            for (int i = 0; i < totalArtLength; i++)
            {
                int[,] tempArt = new int[5, 7];
                for (int j = 0; j < 5; j++)
                {
                    int[] tempArtRow = Console.ReadLine().Select(n => n == 'X' ? 1 : -1).ToArray();

                    for (int k = 0; k < 7; k++)
                        tempArt[j, k] = tempArtRow[k];

                    ArtArray[i] = tempArt;
                }
            }

            int count = int.MaxValue;

            int result1 = 0;
            int result2 = 0;

            for (int i = 0; i < totalArtLength; i++)
            {
                for (int j = 0; j < totalArtLength; j++)
                {
                    if (i == j)
                        continue;

                    int tempCount = Cal(ArtArray[i], ArtArray[j]);

                    if (count > tempCount)
                    {
                        count = tempCount;
                        result1 = i;
                        result2 = j;
                    }
                }
            }

            if (result1++ > result2++)
                Console.WriteLine($"{result2} {result1}");
            else
                Console.WriteLine($"{result1} {result2}");
        }

        static int Cal(int[,] art1, int[,] art2)
        {
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (art1[i, j] != art2[i, j])
                        result++;
                }
            }
            return result;
        }
    }
}
