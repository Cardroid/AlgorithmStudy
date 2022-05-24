using System;

namespace AlgorithmStudy.Problems._2107_2w_021
{
    class _6679
    {
        static void Main()
        {
            int num = 2992;

            while (num < 10000)
            {
                int temp = Cal(num, 12);

                if (Cal(num, 10) == temp && temp == Cal(num, 16))
                    Console.WriteLine(num);

                num++;
            }
        }

        static int Cal(int a, int b)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += a % b;
                a /= b;
            }
            return sum;
        }
    }
}
