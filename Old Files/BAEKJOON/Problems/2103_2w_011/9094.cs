using System;

namespace BAEKJOON.Problems._2103_2w
{
    class _9094
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                int n = int.Parse(s[0]);
                int m = int.Parse(s[1]);
                int result = 0;

                for (int a = 1; a < n - 1; a++)
                {
                    for (int b = a + 1; b < n; b++)
                    {
                        if ((a * a + b * b + m) % (a * b) == 0)
                            result++;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
