using System;
using System.Linq;

namespace AlgorithmStudy.Problems._2110
{
    class _3003
    {
        static void Main()
        {
            int[] pieces = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int[] result = new int[6];

            result[0] = 1 - pieces[0];
            result[1] = 1 - pieces[1];
            result[2] = 2 - pieces[2];
            result[3] = 2 - pieces[3];
            result[4] = 2 - pieces[4];
            result[5] = 8 - pieces[5];

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
