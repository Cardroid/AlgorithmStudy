using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Problems._2106_4w_019
{
    class _16395
    {
        static void Main()
        {
            int[,] c = new int[31, 31];

            string[] temp = Console.ReadLine().Split();
            int n = int.Parse(temp[0]);
            int k = int.Parse(temp[1]);

            for (int i = 0; i < 31; i++)
            {
                c[i, 0] = 1;
            }

            for (int i = 1; i < 31; i++)
            {
                for (int j = 1; j <= i; j++)
                    c[i, j] = c[i - 1, j - 1] + c[i - 1, j];
            }

            Console.WriteLine(c[n - 1, k - 1]);
        }
    }
}
