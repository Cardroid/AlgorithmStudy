using System;
using System.Linq;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _1932
    {
        static void Main()
        {
            int height = int.Parse(Console.ReadLine());

            int[][] triangle = new int[height][];

            for (int i = 0; i < height; i++)
                triangle[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = height - 1; i > 0; i--)
            {
                int[] upLayer = triangle[i - 1];
                int[] layer = triangle[i];

                for (int j = 0; j < layer.Length - 1; j++)
                {
                    int maxNeighbor = Math.Max(layer[j], layer[j + 1]);

                    upLayer[j] += maxNeighbor;
                }
            }

            Console.WriteLine(triangle[0][0]);
        }
    }
}
