using System;
using System.Linq;
using System.Text;

namespace AlgorithmStudy.Problems._2110
{
    class _1343
    {
        static void Main()
        {
            string board = Console.ReadLine();
            StringBuilder result = new();
            string[] block = board.Split('.').ToArray();

            for (int i = 0; i < block.Length; i++)
            {
                if (block[i].Length % 2 != 0)
                {
                    Console.WriteLine(-1);
                    return;
                }
                else
                {
                    int aBlockCount = block[i].Length / 4;
                    int bBlockCount = block[i].Length % 4 == 2 ? 1 : 0;
                    result.Append('A', aBlockCount * 4);
                    result.Append('B', bBlockCount * 2);
                }

                if (i != block.Length - 1)
                    result.Append('.');
            }

            Console.WriteLine(result.ToString());
        }
    }
}
