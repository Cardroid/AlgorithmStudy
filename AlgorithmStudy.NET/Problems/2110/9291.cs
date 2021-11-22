using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Problems._2110
{
    class _9291
    {
        static void Main()
        {
            static bool Check(int[] array) => array.Sum() == 45 && array.Distinct().Count() == 9;

            int count = int.Parse(Console.ReadLine());
            int[][] board = new int[9][];

            for (int testCase = 0; testCase < count; testCase++)
            {
                bool isCorrect = true;

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    board[i] = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
                }

                Console.ReadLine();

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    isCorrect &= Check(board[i]);
                }

                List<int> col = new();
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    col.Clear();
                    for (int j = 0; j < board.GetLength(0); j++)
                    {
                        col.Add(board[j][i]);
                    }
                    isCorrect &= Check(col.ToArray());
                }

                for (int i = 0; i < 9; i++)
                {

                }
            }
        }
    }
}
