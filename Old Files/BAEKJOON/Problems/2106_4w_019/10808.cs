using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON.Problems._2106_4w_019
{
    class _10808
    {
        static void Main()
        {
            int[] result = new int[26];
            string S = Console.ReadLine();

            for (int i = 0; i < S.Length; i++)
            {
                char Schar = S[i];
                result[Schar - 97]++;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
