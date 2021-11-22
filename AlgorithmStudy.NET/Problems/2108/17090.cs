using System;
using System.Collections.Generic;
using System.Threading;

namespace AlgorithmStudy.Problems._2108
{
    class _17090
    {
        static void Main()
        {
            string[] _inputTemp = Console.ReadLine().Split();
            int Y = int.Parse(_inputTemp[0]);
            int X = int.Parse(_inputTemp[1]);
            char[,] Board = new char[Y, X];
            int[,] Memory = new int[500, 500];
            int Result = 0;

            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    Memory[i, j] = 0;
                }
            }

            for (int i = 0; i < Y; i++)
            {
                string temp = Console.ReadLine();

                for (int j = 0; j < X; j++)
                {
                    Board[i, j] = temp[j];
                }
            }

            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    if (Search(Board, j, i, X, Y, Memory))
                        Result++;
                }
            }

            Console.WriteLine(Result);
        }

        static bool Search(char[,] board, int x, int y, int xLength, int yLength, int[,] memory)
        {
            Stack<Tuple<int, int>> footPrint = new();

            if (memory[y, x] != 0)
                return memory[y, x] == 1;

            while (true)
            {
                Tuple<int, int> currentPos = Tuple.Create(y, x);

                if (x < 0 || y < 0 || x >= xLength || y >= yLength)
                {
                    refer.Result = true;
                    memory[currentPos] = refer;
                    return true;
                }
                else if (footPrint.Contains(currentPos))
                {
                    refer.Result = false;
                    memory[currentPos] = refer;
                    return false;
                }
                else
                    memory[currentPos] = refer;

                footPrint.Push(currentPos);

                switch (board[y, x])
                {
                    case 'U':
                        y--;
                        break;
                    case 'R':
                        x++;
                        break;
                    case 'D':
                        y++;
                        break;
                    case 'L':
                        x--;
                        break;
                }
            }
        }
    }
}
