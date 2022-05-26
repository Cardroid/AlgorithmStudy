using System;

namespace AlgorithmStudy.Problems._2109
{
    class _1520
    {
        static int[] dx = { -1, 0, 1, 0 };
        static int[] dy = { 0, -1, 0, 1 };
        static int[,] Board, Book;
        static int XLen, YLen;

        static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');
            XLen = int.Parse(temp[1]);
            YLen = int.Parse(temp[0]);
            Board = new int[XLen, YLen];
            Book = new int[XLen, YLen];

            for (int y = 0; y < YLen; y++)
            {
                temp = Console.ReadLine().Split(' ');

                for (int x = 0; x < XLen; x++)
                {
                    Board[x, y] = int.Parse(temp[x]);
                    Book[x, y] = -1;
                }
            }

            Console.WriteLine(PathFind(0, 0));
        }

        private static int PathFind(int x, int y)
        {
            if (x == XLen - 1 && y == YLen - 1)
                return 1;

            if (Book[x, y] == -1)
            {
                Book[x, y] = 0;
                for (int i = 0; i < 4; i++)
                {
                    int mX = dx[i] + x;
                    int mY = dy[i] + y;

                    if (0 <= mX && mX < XLen && 0 <= mY && mY < YLen)
                    {
                        if (Board[x, y] > Board[mX, mY])
                            Book[x, y] += PathFind(mX, mY);
                    }
                }
            }
            return Book[x, y];
        }
    }
}
