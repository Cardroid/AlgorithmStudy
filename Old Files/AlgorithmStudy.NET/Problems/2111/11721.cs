using System;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _11721
    {
        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (i != 0 && i % 10 == 0)
                    Console.WriteLine();

                Console.Write(input[i]);
            }
        }
    }
}
