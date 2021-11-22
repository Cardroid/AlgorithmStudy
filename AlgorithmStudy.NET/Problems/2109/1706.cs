using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmStudy.Problems._2109
{
    class _1706
    {
        static void Main()
        {
            var temp = Console.ReadLine().Split(' ');
            int R = int.Parse(temp[0]), C = int.Parse(temp[1]);
            char[,] board = new char[R, C];
            StringBuilder stringBuilder = new();
            List<string> result = new();

            for (int i = 0; i < R; i++)
            {
                var line = Console.ReadLine();

                for (int j = 0; j < C; j++)
                    board[i, j] = line[j];
            }

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (board[i, j] == '#')
                    {
                        if (stringBuilder.Length > 1)
                            result.Add(stringBuilder.ToString());
                        stringBuilder.Clear();
                    }
                    else
                        stringBuilder.Append(board[i, j]);
                }

                if (stringBuilder.Length > 1)
                    result.Add(stringBuilder.ToString());
                stringBuilder.Clear();
            }

            for (int i = 0; i < C; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    if (board[j, i] == '#')
                    {
                        if (stringBuilder.Length > 1)
                            result.Add(stringBuilder.ToString());
                        stringBuilder.Clear();
                    }
                    else
                        stringBuilder.Append(board[j, i]);
                }

                if (stringBuilder.Length > 1)
                    result.Add(stringBuilder.ToString());
                stringBuilder.Clear();
            }

            result.Sort();

            Console.WriteLine(result.First());
        }
    }
}
