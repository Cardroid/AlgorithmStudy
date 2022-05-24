using System;

namespace BAEKJOON.Contest.Startup_Coding_Festival_2021._1
{

    // 팝업스토어

    class Test6
    {
        static void Main()
        {
            string[] tStr = Console.ReadLine().Split(' ');

            int width = int.Parse(tStr[0]);
            int height = int.Parse(tStr[1]);

            int[,] array = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    array[i, j] = int.Parse(temp[j]);
            }

            Console.WriteLine(Explore(array, new Point(0, 0), 0));
        }

        static int Explore(int[,] array, Point index, int result)
        {
            int x = index.X;
            int y = index.Y;
            result += array[y, x];

            if (x == array.GetLength(1) - 1 && y == array.GetLength(0) - 1)
                return result;

            if (x == array.GetLength(1) - 1)
                return Explore(array, new Point(x, y + 1), result);
            else if (y == array.GetLength(0) - 1)
                return Explore(array, new Point(x + 1, y), result);
            else
                return Math.Max(Explore(array, new Point(x + 1, y), result), Explore(array, new Point(x, y + 1), result));
        }

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
