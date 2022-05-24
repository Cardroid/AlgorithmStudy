using System;

namespace AlgorithmStudy.Problems._2110
{
    class _1934
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                int a = int.Parse(temp[0]);
                int b = int.Parse(temp[1]);

                int na = a;
                int nb = b;

                while (nb != 0)
                {
                    int r = na % nb;

                    na = nb;
                    nb = r;
                }

                Console.WriteLine(a * b / na);
            }
        }
    }
}
