using System;
using System.Collections.Generic;

namespace AlgorithmStudy.NET.Problems.Seminar
{
    public class _2178
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');

            int N = int.Parse(temp[0]);
            int M = int.Parse(temp[1]);

            for (int i = 0; i < N; i++)
            {
                var line = Console.ReadLine();
                for (int j = 0; j < M; j++)
                    Map[i, j] = line[j];
            }

            BFS(N, M);
        }

        private static int[,] Check = new int[101, 101];
        private static int[,] Visit = new int[101, 101];
        private static char[,] Map = new char[101, 101];

        static void BFS(int N, int M)
        {
            Visit[0, 0] = 1;

            Queue<Point> queue = new();

            queue.Enqueue(new Point(0, 0));

            while (queue.Count > 0)
            {
                var p = queue.Dequeue();
                int x = p.X;
                int y = p.Y;

                for (int i = 0; i < 4; i++)
                {
                    int next_x = x + MoveX[i];
                    int next_y = y + MoveY[i];

                    if (0 <= next_x && next_x < N && 0 <= next_y && next_y < M)
                    {
                        if (Map[next_x, next_y] == '1' && Visit[next_x, next_y] == 0)
                        {
                            Check[next_x, next_y] = Check[x, y] + 1;
                            Visit[next_x, next_y] = 1;
                            queue.Enqueue(new Point(next_x, next_y));
                        }
                    }
                }
            }

            Console.WriteLine(Check[N - 1, M - 1] + 1);
        }

        private static int[] MoveX = new int[] { 1, 0, -1, 0 };
        private static int[] MoveY = new int[] { 0, 1, 0, -1 };

        struct Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }
        }
    }
}
