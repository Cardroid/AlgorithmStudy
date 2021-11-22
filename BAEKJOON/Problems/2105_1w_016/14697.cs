using System;

namespace BAEKJOON.Problems._2105_1w
{
    class _14697
    {
        static void Main()
        {
            string[] argv = Console.ReadLine().Split();

            int[] roomArray = new int[]
            {
                int.Parse(argv[0]),
                int.Parse(argv[1]),
                int.Parse(argv[2]),
            };

            int people = int.Parse(argv[3]);

            bool flag = false;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        if (i * roomArray[0] + j * roomArray[1] + k * roomArray[2] == people)
                            flag = true;

                        if (flag)
                            break;
                    }

                    if (flag)
                        break;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(flag ? 1 : 0);
        }
    }
}
