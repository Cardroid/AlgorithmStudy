using System;

namespace BAEKJOON.Contest.Startup_Coding_Festival_2021._1
{

    // 시선 이동

    class Test5
    {
        static void Main()
        {
            string[] tStr = Console.ReadLine().Split(' ');

            int width = int.Parse(tStr[0]);
            int height = int.Parse(tStr[1]);

            int[,] array = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                string temp = Console.ReadLine();
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == '.')
                        array[i, j] = 0;
                    else if (temp[j] == 'x')
                        array[i, j] = -1;
                    if (temp[j] == 'c')
                        array[i, j] = 1;
                }
            }

            int result = int.MaxValue;

            for (int x = 0; x < array.GetLength(1); x++)
            {
                if (array[0, x] == 1)
                {
                    int tempResult = Explore(ArrayCopy(array), new Point(x, 0), 0);

                    if (result > 0 && tempResult > 0)
                        result = Math.Min(result, tempResult);
                    else if (tempResult > 0)
                        result = tempResult;
                }
            }

            Console.WriteLine(result);
        }

        static int Explore(int[,] array, Point index, int result)
        {
            int x = index.X;
            int y = index.Y;
            array[y, x] = -1;

            if (y >= array.GetLength(0) - 1)
                return result;

            if (y + 1 < array.GetLength(0) && array[y + 1, x] != -1)
                return Explore(array, new Point(x, y + 1), result);
            else
            {
                bool isRight = x + 1 < array.GetLength(1) && array[y, x + 1] != -1;
                bool isLeft = x - 1 >= 0 && array[y, x - 1] != -1;

                if (isRight && isLeft)
                {
                    result++;
                    int r1 = Explore(ArrayCopy(array), new Point(x + 1, y), result);
                    int r2 = Explore(ArrayCopy(array), new Point(x - 1, y), result);

                    return r1 > 0 && r2 > 0 ? Math.Min(r1, r2) : (r1 > 0 ? r1 : r2);
                }
                else if (isRight)
                    return Explore(ArrayCopy(array), new Point(x + 1, y), ++result);
                else if (isLeft)
                    return Explore(ArrayCopy(array), new Point(x - 1, y), ++result);
                else
                    return -1;
            }
        }

        static int[,] ArrayCopy(int[,] array)
        {
            int[,] tArray = new int[array.GetLength(0), array.GetLength(1)];
            Array.Copy(array, tArray, array.Length);
            return tArray;
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
