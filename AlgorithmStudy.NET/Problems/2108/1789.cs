using System;
using System.Numerics;

namespace AlgorithmStudy.Problems._2108
{
    class _1789
    {
        static void Main()
        {
            uint S = uint.Parse(Console.ReadLine());
            int MAX_N = 0;
            BigInteger count = 0;

            for (int i = 1; i < 92683; i++)
            {
                MAX_N++;
                count += i;

                if (count > S)
                {
                    MAX_N--;
                    break;
                }
            }

            Console.WriteLine(MAX_N);
        }
    }
}
