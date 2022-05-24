using System;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _1371
    {
        static void Main()
        {
            int[] result = new int[26];
            string input = Console.In.ReadToEnd();

            for (int i = 0; i < input.Length; i++)
            {
                if ('a' <= input[i] && input[i] <= 'z')
                    result[input[i] - 97]++;
            }

            int max = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > max)
                    max = result[i];
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == max && result[i] != 0)
                    Console.Write((char)(i + 97));
            }
        }
    }
}
