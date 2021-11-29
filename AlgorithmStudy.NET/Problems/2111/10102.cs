using System;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _10102
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());
            char[] input = Console.ReadLine().ToCharArray();

            int[] result = new int[2];

            for (int t = 0; t < testCase; t++)
                result[input[t] == 'A' ? 0 : 1]++;

            if (result[0] == result[1])
                Console.WriteLine("Tie");
            else
                Console.WriteLine(result[0] > result[1] ? 'A' : 'B');
        }
    }
}
