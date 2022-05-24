using System;

namespace AlgorithmStudy.Problems._2110
{
    class _15963
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');
            int n = int.Parse(temp[0]);
            int m = int.Parse(temp[1]);

            if (n == m)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
