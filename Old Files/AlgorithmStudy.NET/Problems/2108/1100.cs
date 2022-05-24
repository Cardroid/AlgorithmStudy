using System;

namespace AlgorithmStudy.Problems._2108
{
    class _1100
    {
        static void Main()
        {
            string line;
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                line = Console.ReadLine();

                for (int j = i % 2; j < 8; j += 2)
                {
                    if (line[j] == 'F')
                        result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
