using System;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _4458
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());

            for (int t = 0; t < testCase; t++)
            {
                char[] buffer = Console.ReadLine().ToCharArray();
                buffer[0] = buffer[0].ToString().ToUpper()[0];
                Console.WriteLine(new string(buffer));
            }
        }
    }
}
