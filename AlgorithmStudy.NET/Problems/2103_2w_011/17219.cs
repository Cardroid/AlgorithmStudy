using System;
using System.Collections.Generic;

namespace BAEKJOON.Problems._2103_2w
{
    class _17219
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            int inputLength = int.Parse(s[0]);
            int outputLength = int.Parse(s[1]);

            Dictionary<string, string> pws = new Dictionary<string, string>();

            for (int i = 0; i < inputLength; i++)
            {
                string[] sitePw = Console.ReadLine().Split(' ');
                pws[sitePw[0]] = sitePw[1];
            }

            for (int i = 0; i < outputLength; i++)
            {
                Console.WriteLine(pws[Console.ReadLine()]);
            }
        }
    }
}
