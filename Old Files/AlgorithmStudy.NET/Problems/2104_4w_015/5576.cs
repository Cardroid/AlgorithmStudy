using System;
using System.Collections.Generic;

namespace BAEKJOON.Problems._2104_4w
{
    class _5576
    {
        static void Main()
        {
            List<int> W = new List<int>();
            List<int> K = new List<int>();

            for (int i = 0; i < 10; i++)
                W.Add(int.Parse(Console.ReadLine()));
            for (int i = 0; i < 10; i++)
                K.Add(int.Parse(Console.ReadLine()));

            W.Sort();
            K.Sort();

            W.Reverse();
            K.Reverse();

            Console.WriteLine($"{W[0] + W[1] + W[2]} {K[0] + K[1] + K[2]}");
        }
    }
}
