using System;
using System.Collections.Generic;

namespace AlgorithmStudy.Problems._2108
{
    class _2217
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());
            List<int> ropes = new();
            int max = 0;

            for (int i = 0; i < testCase; i++)
                ropes.Add(int.Parse(Console.ReadLine()));

            ropes.Sort();

            for (int i = ropes.Count - 1; i >= 0; i--)
            {
                ropes[i] = ropes[i] * (ropes.Count - i);
                if (max < ropes[i])
                    max = ropes[i];
            }

            Console.WriteLine(max);
        }
    }
}
