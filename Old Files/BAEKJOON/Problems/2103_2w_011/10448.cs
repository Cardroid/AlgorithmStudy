using System;

namespace BAEKJOON.Problems._2103_2w
{
    class _10448
    {
        static void Main()
        {
            int lineLength = int.Parse(Console.ReadLine());

            for (int line = 0; line < lineLength; line++)
            {
                int t = int.Parse(Console.ReadLine());
                int result = 0;

                for (int i = 1; i <= 44; i++)
                {
                    for (int j = 1; j <= 44; j++)
                    {
                        for (int k = 1; k <= 44; k++)
                        {
                            if (GetTriangleNum(i) + GetTriangleNum(j) + GetTriangleNum(k) == t)
                            {
                                result = 1;
                                break;
                            }
                        }

                        if (result == 1)
                            break;
                    }

                    if (result == 1)
                        break;
                }

                Console.WriteLine(result);
            }
        }

        static int GetTriangleNum(int i) => i * (i + 1) / 2;
    }
}
