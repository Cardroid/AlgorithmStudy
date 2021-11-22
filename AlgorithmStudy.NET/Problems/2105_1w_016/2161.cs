using System;
using System.Collections.Generic;
using System.Linq;

namespace BAEKJOON.Problems._2105_1w
{
    class _2161
    {
        static void Main()
        {
            int value = int.Parse(Console.ReadLine());

            Queue<int> Q = new Queue<int>();

            for (int i = 1; i <= value; i++)
            {
                Q.Enqueue(i);
            }

            List<int> result = new List<int>();
            result.Add(Q.Dequeue());

            while (Q.Count > 0)
            {
                Q.Enqueue(Q.Dequeue());
                result.Add(Q.Dequeue());
            }

            Console.WriteLine(string.Join(" ", result.Select(i => i.ToString())));
        }
    }
}
