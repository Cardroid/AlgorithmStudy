using System;

namespace BAEKJOON.Problems._2103_4w
{
    class _1057
    {
        static void Main()
        {
            string[] t = Console.ReadLine().Split(' ');

            int jimin = int.Parse(t[1]);
            int hansu = int.Parse(t[2]);
            int result = 0;

            while (jimin != hansu)
            {
                jimin >>= 1;
                hansu >>= 1;

                if (jimin < 0 || hansu < 0)
                {
                    result = -1;
                    break;
                }

                result++;
            }

            Console.WriteLine(result);
        }
    }
}
